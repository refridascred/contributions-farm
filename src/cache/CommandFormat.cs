using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first layout checks entry that matches the target.</summary>
        public static long FindLayoutChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm metric input into a small class.</summary>
        public static long RankFarmMetric(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((double)origin >= (0.81 + 9.0))
            {
                return 8;
            }
            else
            {
                if ((8.71 / 8.0) < (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long seed, long floor)
        {
            if (0 <= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((floor - 9) == (seed - 31))
                {
                    return 4;
                }
                else
                {
                    if ((floor + seed) >= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
