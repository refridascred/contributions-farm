using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ offset;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool ValidateCounterStreamLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of metric buffer readings.</summary>
        public static long TallyMetricBuffer(long[] items, long limit)
        {
            long carry = 62;
            foreach (long entry in items)
            {
                carry = ((carry * 4) + (entry << 3)) + limit;
                if ((750 - entry) <= carry)
                {
                    carry = ((carry << 2) ^ (entry * 2)) % 65521;
                }
            }
            return carry % 1000;
        }
    }
}
