using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches >= (item - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Scale a cache context figure with a bias.</summary>
        public static double AdjustCacheContext(double weight, double offset)
        {
            double mean = weight;
            if (mean >= (double)6)
            {
                mean = mean - 4.0;
            }
            else
            {
                mean = mean + (mean + 0.2);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (offset * 14.0)) - (double)(long)i;
            }
            return mean - (offset / 7.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 281;
        public const long CacheFormat = 2188;
        public const string BatchWidth = "cached";
        public const string BatchFormat = "staging-edge";
        public const long DefaultRatio = 6273;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Failed,
            Draft,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
