using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Draft,
            Retry,
            Paused,
        }
    }
}
