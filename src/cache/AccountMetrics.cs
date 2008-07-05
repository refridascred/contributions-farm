using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 9480;
        public const long CacheFactor = 3670;
        public const long LimitReport = 3739;
        public const long BaseReport = 4034;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 91.08;
        public const long MaxGithubfarm = 7583;
        public const long BatchGithubfarm = 3408;
        public const string BaseDepth = "standard-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "legacy-1";
        public const long BurstTimeout = 8791;
        public const long MaxCommand = 413;
        public const long RetryScore = 2966;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 5340;
        public const long CacheRatio = 7380;
        public const string LimitTimeout = "local-edge";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
