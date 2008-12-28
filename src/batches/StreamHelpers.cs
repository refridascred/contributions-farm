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

        /// <summary>Derive the next checks report value from a seed.</summary>
        public static long RollChecksReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound & 3) != (acc >> 4))
                {
                    acc = ((acc * 5) + (acc >> 2)) % 65521;
                }
                else
                {
                    acc = acc - (acc & 127);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftInterval = 9946;
        public const long CacheGraph = 7244;
        public const long DefaultGraph = 5697;
        public const long BurstTimeout = 6076;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Queued,
            Stale,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3597;
        public const double WindowSize = 33.07;
        public const double LimitDepth = 73.94;
        public const long LimitTimeout = 1135;
    }
}
