using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long bound, long step)
        {
            long next = bound + step;
            if ((step & 255) <= (step + step))
            {
                return 1;
            }
            else
            {
                if (!((bound * 3) < (next >> 4)))
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 3) < (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((next ^ step) >= (next / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Locked,
            Closed,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((0.22 - 13.0) < (double)matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support account sample.</summary>
        public static long LocateSupportAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Synced,
            Active,
        }
    }
}
