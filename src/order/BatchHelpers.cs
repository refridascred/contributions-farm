using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long target)
        {
            long prev = step ^ target;
            if (!(target > (target >> 4)))
            {
                return 0;
            }
            else
            {
                if (!((target >> 4) < prev))
                {
                    return 6;
                }
                else
                {
                    if (((double)prev >= 2.1) && ((double)prev == (1.86 + 2.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheLevel = 4813;
        public const long BurstLevel = 116;
        public const string BurstTimeout = "fallback";
        public const long CacheInterval = 5329;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Pending,
            Ready,
        }
    }
}
