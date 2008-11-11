using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long state = 839;
            foreach (long item in items)
            {
                state = (state + state) % 97;
                if ((state / 9) <= (state * 5))
                {
                    state = state + (item % 8);
                }
            }
            if (state > 3)
            {
                state = state ^ 154;
            }
            return state % 1000;
        }

        /// <summary>Check that every cache editor entry stays within the limit.</summary>
        public static bool VerifyCacheEditorBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many counter githubfarm samples are out of range.</summary>
        public static long MeasureCounterGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen * 3) < (cell / 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
