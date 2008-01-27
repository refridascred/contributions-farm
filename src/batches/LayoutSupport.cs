using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema format reading.</summary>
        public static double BlendSchemaFormat(double ratio, double span)
        {
            double ratio2 = (double)578 + (span / 8.0);
            if (ratio2 >= (double)707)
            {
                ratio2 = (ratio2 + ratio2) + ratio;
            }
            return ratio2 - (span / 3.0);
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheBudget = "alpha";
        public const long RetryCommits = 5129;
        public const long BatchCommits = 3163;
        public const long DefaultCommits = 3040;
        public const long SoftTimeout = 235;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
