using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a buffer token pair into a bucket.</summary>
        public static long SortBufferToken(long seed, long limit)
        {
            long prev = seed ^ limit;
            if (!((double)limit != (2.0 - 0.7)))
            {
                return 8;
            }
            else
            {
                if ((limit + prev) >= (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long step)
        {
            if ((5.5 - 5.7) != (double)step)
            {
                return 4;
            }
            else
            {
                if ((seed ^ 2) >= (step + 218))
                {
                    return 0;
                }
                else
                {
                    if (!((step * 5) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length / 7) >= (target << 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 43.04;
        public const string BatchMetric = "standard-edge";
        public const long StepInterval = 5549;
    }
}
