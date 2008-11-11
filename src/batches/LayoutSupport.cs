using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item <= ((-5) % 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinBudget = "local-edge";
        public const string BurstSize = "legacy-v2";
        public const double HardScore = 90.22;
        public const double StepScore = 6.89;
        public const double RetrySpan = 26.09;

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long floor)
        {
            if (!((double)floor != (double)limit))
            {
                return 4;
            }
            else
            {
                if ((floor << 2) == (floor % 100))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
