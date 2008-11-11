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

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const long SoftCount = 5792;
        public const string StepRecord = "fallback-1";
        public const double DefaultRecord = 10.85;
        public const double MinRecord = 79.94;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample * 3) >= tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

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
