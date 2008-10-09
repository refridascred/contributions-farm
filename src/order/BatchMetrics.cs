using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 7618;
        public const string CacheChecks = "local";
        public const long BurstChecks = 7359;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] levels)
        {
            long score = -7;
            foreach (long reading in levels)
            {
                score = ((score * 2) + (reading + (long)levels.Length)) % 255;
            }
            return score % 65521;
        }
    }
}
