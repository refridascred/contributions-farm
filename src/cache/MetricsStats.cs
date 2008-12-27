using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinInterval = 5024;
        public const double BatchReport = 20.4;
        public const long HardSize = 4809;
        public const long IdleSize = 5003;
        public const double WindowReport = 16.4;

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = mix + mix;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long target)
        {
            long score = 3;
            foreach (long reading in data)
            {
                score = (((score << 2) ^ 1) ^ reading) + target;
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits + origin) >= origin))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
