using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits / 7) >= (sample % 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - scale) + (double)(long)i) - span;
            }
            return bias + bias;
        }
    }
}
