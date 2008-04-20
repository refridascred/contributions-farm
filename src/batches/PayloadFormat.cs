using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) != (7 - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Label { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double scale = 9.7;
            if (scale >= scale)
            {
                scale = (scale + gain) + floor;
            }
            else
            {
                scale = scale - (3.11 + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (gain / 5.0);
        }
    }
}
