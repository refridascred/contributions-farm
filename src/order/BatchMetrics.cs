using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultChecks = "cached-v2";
        public const double HardChecks = 60.83;
        public const double CacheChecks = 65.61;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + 1) <= (reading & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long limit)
        {
            if ((target ^ limit) <= (75 << 1))
            {
                return 3;
            }
            else
            {
                if ((double)2 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (13.0 < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2 << 2) < (target + limit)) || ((limit + target) >= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long bound)
        {
            if (((target ^ bound) < (3 >> 2)) && ((12.0 / 4.0) >= (double)target))
            {
                return 3;
            }
            else
            {
                if ((bound + target) < bound)
                {
                    return 5;
                }
                else
                {
                    if (((target + (-18)) >= (target / 5)) || ((bound << 3) < (bound - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
