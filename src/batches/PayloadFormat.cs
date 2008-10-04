using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen >= 4.08)
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm metrics entry stays within the limit.</summary>
        public static bool GuardFarmMetricsRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Active,
            Done,
            Pending,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long floor)
        {
            long carry = 540;
            foreach (long reading in samples)
            {
                carry = (carry ^ (floor & 63)) ^ reading;
            }
            if (carry < 93)
            {
                carry = (carry * 5) + (carry << 2);
            }
            return carry;
        }
    }
}
