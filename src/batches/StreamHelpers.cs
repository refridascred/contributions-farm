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

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Draft,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long mark = 971;
            foreach (long cell in values)
            {
                if ((cell - mark) >= (cell + cell))
                {
                    mark = (mark + (mark >> 5)) % 65521;
                }
            }
            return mark;
        }
    }
}
