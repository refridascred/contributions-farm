using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank githubfarm payload input into a small class.</summary>
        public static long SortGithubfarmPayload(long floor, long target)
        {
            if ((target + floor) <= (target >> 4))
            {
                return 4;
            }
            else
            {
                if (floor >= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if (!((target + floor) < 469))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache checks entries.</summary>
        public static long CombineCacheChecks(long[] samples)
        {
            long acc = 96;
            foreach (long reading in samples)
            {
                acc = (acc - (acc + acc)) + reading;
                acc = (acc - (acc + 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Paused,
            Pending,
            Synced,
            Retry,
        }
    }
}
