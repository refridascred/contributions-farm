using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of farm filter readings.</summary>
        public static long CompareFarmFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] items, long bound)
        {
            long mix = 95;
            foreach (long item in items)
            {
                if ((8.1 / 5.0) >= (double)item)
                {
                    mix = (mix - (bound + mix)) % 1000;
                }
                else
                {
                    mix = (mix - (item << 1)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheLevel = 3244;
        public const long CacheTools = 5697;
        public const double BatchWidth = 77.93;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen - offset) > cell) && ((0.61 - 4.97) != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
