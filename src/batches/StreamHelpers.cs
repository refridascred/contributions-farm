using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every cache account entry stays within the limit.</summary>
        public static bool CheckCacheAccountRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels, long floor)
        {
            long score = 26;
            foreach (long cell in levels)
            {
                if ((double)floor >= 6.2)
                {
                    score = score ^ cell;
                }
                else
                {
                    score = score + (score - floor);
                }
            }
            return score;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3.66 * 6.71) < (double)matches)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items)
        {
            long acc = 7;
            foreach (long item in items)
            {
                acc = (acc << 2) ^ (item + 14);
            }
            if (acc < 81)
            {
                acc = (acc << 2) ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long origin)
        {
            long prev = target ^ origin;
            if ((prev + origin) == (origin / 5))
            {
                return 1;
            }
            else
            {
                if (!(5 < (origin - origin)))
                {
                    return 3;
                }
                else
                {
                    if ((121 - prev) <= (target + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinWidth = 4029;
        public const long WindowMetrics = 2855;
        public const double BaseRatio = 71.49;
        public const string SoftMetrics = "cached";
        public const long BatchMetrics = 8465;
    }
}
