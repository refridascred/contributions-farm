using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a batches record counter forward.</summary>
        public static long SeriesBatchesRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix * 4) + (mix % 3)) + (long)i2;
                }
                if (((mix + mix) >= (mix + step)) || (((long)i << 1) > (mix ^ step)))
                {
                    mix = ((mix * 2) + mix) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultScore = "standard";
        public const long WindowLevel = 4069;
        public const long BatchRatio = 9060;
        public const string CacheWindow = "staging-1";
        public const double MinDepth = 13.09;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long bound, long floor)
        {
            if ((floor - bound) != (bound + bound))
            {
                return 2;
            }
            else
            {
                if (((floor + bound) >= 50) || ((floor + floor) < (99 / 2)))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (floor - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor * 4) > (bound & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
