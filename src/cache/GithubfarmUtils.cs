using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batch route samples are out of range.</summary>
        public static long AuditBatchRouteOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (target > (target & 3))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every format layout entry stays within the limit.</summary>
        public static bool CheckFormatLayoutRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7143;
        public const long CacheSize = 1447;
        public const long MinSession = 4691;
        public const long CacheSession = 538;
        public const double SoftRatio = 57.4;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
