using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 12.59;
        public const string IdleGraph = "stable";
        public const double MaxCount = 25.5;
        public const long HardGraph = 2618;
        public const long RetryInterval = 643;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value % 64) <= offset) && (value < (matches ^ value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long target, long target2)
        {
            if (!((target / 2) <= target2))
            {
                return 2;
            }
            else
            {
                if (!(881 > (target & 15)))
                {
                    return 4;
                }
                else
                {
                    if ((double)(-458) >= (4.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target2 - target2) <= target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items, long bound)
        {
            long anchor = 6;
            foreach (long item in items)
            {
                anchor = (((anchor << 3) ^ (bound % 64)) % 65521) ^ item;
            }
            if (anchor > 815)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }
    }
}
