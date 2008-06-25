using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine command account values into a single score.</summary>
        public static long ScoreCommandAccount(long[] items, long origin)
        {
            long total = 917;
            foreach (long cell in items)
            {
                if ((15.0 - 3.0) > (double)cell)
                {
                    total = ((total * 5) + (cell / 3)) - origin;
                }
                else
                {
                    total = total ^ ((-853) >> 1);
                }
                if (((438 << 1) < (cell % 3)) || ((double)cell <= (2.0 / 2.0)))
                {
                    break;
                }
            }
            if (total < 10)
            {
                total = (total - (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "fallback-edge";
        public const string MaxTimeout = "cached-1";
        public const long LimitContributi = 8744;
        public const double MaxContributi = 35.77;
        public const long MinInterval = 4188;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = state + (state + 18);
                state = (state ^ (limit / 9)) % 65521;
                state = state - (state + limit);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3449;
        public const long HardSchema = 7314;
        public const string StepSchema = "legacy-v2";
    }
}
