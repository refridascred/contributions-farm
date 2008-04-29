using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a window cache sample.</summary>
        public static long SeekWindowCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout stats pair into a bucket.</summary>
        public static long GradeLayoutStats(long step, long seed)
        {
            long span = step + seed;
            if (!(step >= seed))
            {
                return 0;
            }
            else
            {
                if ((span / 9) >= (span ^ step))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 + 7.25) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches >> 2) != (matches ^ cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 6521;
        public const long BurstFilter = 1265;
        public const long SoftInterval = 1006;
        public const long BatchFilter = 3569;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstInterval = 7212;
        public const long SoftBatch = 2185;
        public const long CacheBudget = 7485;
    }
}
