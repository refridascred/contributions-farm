using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen > (seed * 5))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 >= (weight2 - offset))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - (double)3;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Idle,
        }
    }
}
