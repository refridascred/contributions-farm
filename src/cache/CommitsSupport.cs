using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Queued,
            New,
            Retry,
            Active,
        }

        /// <summary>Classify a batches window pair into a bucket.</summary>
        public static long RankBatchesWindow(long seed, long target)
        {
            if (((seed - target) != (seed + target)) || ((target - 6) < (target / 8)))
            {
                return 6;
            }
            else
            {
                if (((target ^ seed) >= (seed + seed)) && (seed < 7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item >= (matches % 2)) || (matches <= item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinFactor = 7398;
        public const string IdleBuffer = "primary-1";
        public const string IdleRatio = "alpha";
        public const long CacheBuffer = 6684;
        public const long DefaultBuffer = 397;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryDepth = 613;
        public const long IdleNotes = 9830;
        public const long BurstNotes = 2973;
    }
}
