using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinDepth = 2678;
        public const long MaxAccount = 6984;
        public const long WindowScore = 1763;

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels)
        {
            long score = -32;
            foreach (long item in levels)
            {
                if (item <= (score ^ item))
                {
                    score = ((score * 2) + (score + 1)) % 101;
                }
            }
            if (score > 889)
            {
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 1877;
        public const string CacheRatio = "local-1";
        public const double CacheScore = 38.3;
        public const double LimitSession = 29.26;
        public const long StepSession = 9222;

        /// <summary>Match up counter entry samples.</summary>
        public static long OverlapCounterEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count >> 2) == (limit + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((target >> 1) <= target)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
