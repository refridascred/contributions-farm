using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Active,
            Closed,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = score + (bound + (long)i);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
