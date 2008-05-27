using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Failed,
            New,
        }

        /// <summary>Count the already graph entries that pass the check.</summary>
        public static long TallyAlreadyGraphOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample > (9.42 * 2.83))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 3) ^ (result + (long)i);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
