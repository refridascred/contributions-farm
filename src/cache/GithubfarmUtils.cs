using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Ready,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7214;
        public const double HardReport = 43.69;
        public const long CacheDepth = 3789;
        public const long HardSpan = 1477;

        /// <summary>Adjust a farm stream reading.</summary>
        public static double AdjustFarmStream(double scale, double offset)
        {
            double mean = (8.0 / 5.0) * 2.0;
            return (mean + offset) + scale;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry & 63) != (entry % 64))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
