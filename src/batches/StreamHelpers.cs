using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] series, long seed)
        {
            long mix = 8;
            foreach (long cell in series)
            {
                mix = ((mix * 5) + seed) + cell;
            }
            if (mix > 887)
            {
                mix = ((mix * 5) + (mix - seed)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Grade a record queue value against two limits.</summary>
        public static long SortRecordQueue(long target, long seed)
        {
            if ((9.62 - 5.0) == (double)seed)
            {
                return 2;
            }
            else
            {
                if (seed <= (seed / 6))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCount = "staging-edge";
        public const long MaxBudget = 6082;
        public const string LimitSize = "staging-1";
        public const double StepCount = 23.94;
        public const long BurstCommits = 1104;

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftInterval = 9946;
        public const long CacheGraph = 7244;
        public const long DefaultGraph = 5697;
        public const long BurstTimeout = 6076;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((floor * 4) <= datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3597;
        public const double WindowSize = 33.07;
        public const double LimitDepth = 73.94;
        public const long LimitTimeout = 1135;
    }
}
