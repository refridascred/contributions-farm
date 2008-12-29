using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < (cell << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 17.73;
        public const long LimitFilter = 3093;
        public const long SoftBudget = 4763;
        public const string BaseInterval = "primary-edge";

        /// <summary>Count the githubfarm batch entries that pass the check.</summary>
        public static long TallyGithubfarmBatchOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) > (target >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
        }
    }
}
