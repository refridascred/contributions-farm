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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "fallback-edge";
        public const string MaxTimeout = "cached-1";
        public const long LimitContributi = 8744;
        public const double MaxContributi = 35.77;
        public const long MinInterval = 4188;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
