using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long MeasureStatsTokenHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen >> 1) == (seen & 31))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double bias2 = offset;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + 16.0) + (double)(long)i) - bias;
            }
            return bias2 + offset;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            New,
            Synced,
            Queued,
        }
    }
}
