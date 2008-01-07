using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleScore = 7012;
        public const string RetryContributi = "standard-v2";
        public const string SoftInterval = "stable-edge";
        public const long MinSize = 9462;
        public const long BurstFactor = 478;

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "alpha-edge";
        public const long CacheCommand = 2880;
        public const long WindowCommand = 1737;
        public const long IdleCommand = 2406;
        public const long BatchCommand = 9515;

        /// <summary>Validate tools report readings against a bound.</summary>
        public static bool ValidateToolsReportLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a entry githubfarm sample.</summary>
        public static long LookupEntryGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double rate, double floor)
        {
            double load = (rate / 8.0) * 2.0;
            return load + (floor * 7.68);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)count <= (5.1 + 9.99)) || !((4 % 24) >= sample))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }
    }
}
