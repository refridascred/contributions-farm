using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally << 2) >= (cell >> 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Stale,
            Draft,
            Active,
            Retry,
        }
    }
}
