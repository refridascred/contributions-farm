using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double bias)
        {
            double drift = bias + 7.11;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - gain;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count < (5 & 31))
                {
                    count = ((count + 3) + value) + target;
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value > (offset << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
