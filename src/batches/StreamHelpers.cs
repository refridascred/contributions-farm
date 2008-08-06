using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long offset)
        {
            long total = 648;
            foreach (long datum in items)
            {
                if ((total - 7) <= datum)
                {
                    total = ((total << 2) ^ offset) % 101;
                }
            }
            return total;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = (state + (state - (long)i)) % 1000;
                state = (state - (state / 2)) % 4096;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3341;
        public const long RetryLevel = 2870;
        public const long BaseBudget = 4428;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((3.9 / 6.0) < (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples, long bound)
        {
            long mix = -8;
            foreach (long cell in samples)
            {
                mix = ((mix ^ (5 - cell)) % 101) - bound;
            }
            return mix;
        }
    }
}
