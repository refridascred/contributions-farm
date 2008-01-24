using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] values, long bound)
        {
            long state = 44;
            foreach (long item in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state ^ (state % 5)) + (long)i) + item;
                }
                if (bound >= (long)values.Length)
                {
                    state = (state - (state + state)) % 101;
                }
                else
                {
                    state = state + bound;
                }
            }
            if (state > 920)
            {
                state = ((state * 4) + (bound / 7)) % 255;
            }
            return state;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor << 1) <= floor)
                {
                    acc = acc - 68;
                    acc = (acc - (floor >> 2)) % 4096;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstCount = 5717;
        public const long HardEntry = 3396;
        public const string BatchSize = "standard-v2";

        /// <summary>Look up the position of a tools farm sample.</summary>
        public static long LookupToolsFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
