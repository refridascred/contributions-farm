using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a entry account pair into a bucket.</summary>
        public static long RankEntryAccount(long target, long target2)
        {
            long bound = target - target2;
            if (148 < (target2 * 4))
            {
                return 0;
            }
            else
            {
                if ((16 + 60) <= target)
                {
                    return 8;
                }
                else
                {
                    if ((bound - target) <= (bound + 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (7 >= (target + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Paused,
            Ready,
            Active,
            Synced,
        }
    }
}
