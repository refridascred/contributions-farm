using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i == (floor ^ sum))
                {
                    sum = sum ^ (floor - (long)i);
                }
                else
                {
                    sum = (sum + ((long)i - sum)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 2743;
        public const long HardWidth = 5739;
        public const string CacheLevel = "primary";
        public const string StepBudget = "cached-v2";

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                acc = (acc + (acc - cell)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((37 % 5) == (offset + item)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
