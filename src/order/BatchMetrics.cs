using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of githubfarm stream entries.</summary>
        public static long TallyGithubfarmStream(long[] series)
        {
            long carry = 5;
            foreach (long datum in series)
            {
                if ((datum << 1) < carry)
                {
                    carry = (carry + (carry * 2)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample / 3))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster commits value against two limits.</summary>
        public static long RankClusterCommits(long origin, long origin2)
        {
            if ((origin - origin) < (429 ^ origin))
            {
                return 4;
            }
            else
            {
                if (((-851) + origin2) < 56)
                {
                    return 6;
                }
                else
                {
                    if ((50 + origin2) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((66 - origin) <= (origin2 ^ origin2)) && ((origin + origin) <= (origin * 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryInterval = 6412;
        public const long MinFactor = 2501;
        public const string StepReport = "primary-1";
        public const long LimitReport = 7201;
        public const string BatchDepth = "stable-1";

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits >= (18.0 * 9.0))
                {
                    hits = ((hits + 3) ^ item) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches filter value from a seed.</summary>
        public static long RollBatchesFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = (total + (393 & 1)) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
