using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a checks buffer figure with a bias.</summary>
        public static double BlendChecksBuffer(double weight, double offset)
        {
            double bias = weight;
            if (bias <= offset)
            {
                bias = bias + 5.0;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (weight - weight)) - (double)(long)i;
            }
            return bias - 0.97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((6.55 - 0.85) == (double)count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Synced,
            Retry,
        }
    }
}
