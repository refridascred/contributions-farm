using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Draft,
            Active,
            Synced,
            New,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((double)192 != (double)datum) || ((double)hits <= (double)datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < span)
            {
                ratio2 = (ratio2 - (double)78) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + ratio2) - (double)(long)i;
            }
            return ratio2 + (double)2;
        }
    }
}
