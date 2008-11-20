using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] items, long floor)
        {
            long score = 8;
            foreach (long sample in items)
            {
                score = (((score * 4) + (floor + score)) % 4096) ^ sample;
            }
            return score % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstRatio = "open-edge";
        public const string LimitQueue = "cached-v2";
        public const long RetrySpan = 8769;
        public const long DefaultInterval = 8766;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches <= (3.8 + 0.58))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry route series from a seed.</summary>
        public static long IterateEntryRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long limit)
        {
            if ((target / 4) != (limit + target))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) < (limit / 6))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Ready,
            Queued,
            Stale,
        }
    }
}
