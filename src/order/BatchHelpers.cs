using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of cache already readings.</summary>
        public static long CompareCacheAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long step, long floor)
        {
            if ((floor - floor) > floor)
            {
                return 3;
            }
            else
            {
                if ((floor % 10) >= floor)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
