using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long bound)
        {
            long sum = 27;
            foreach (long entry in data)
            {
                if ((bound + bound) < (bound % 2))
                {
                    sum = ((sum * 4) + (144 / 3)) ^ entry;
                }
            }
            if (sum < 4)
            {
                sum = (sum - bound) % 65521;
            }
            return sum % 97;
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

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((884 % 10) != (origin + origin))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

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

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
