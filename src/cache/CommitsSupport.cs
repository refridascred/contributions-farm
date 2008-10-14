using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Locked,
            Active,
            Failed,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long seed)
        {
            long cur = target + seed;
            if ((cur + seed) == (target / 9))
            {
                return 8;
            }
            else
            {
                if ((target - 262) > (cur - 53))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 262;
        public const string StepTimeout = "latest-v2";
        public const long MaxFactor = 5036;
        public const long LimitRoute = 2081;
        public const double DefaultCount = 7.25;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item >= (item + 78))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data, long origin)
        {
            long mix = 11;
            foreach (long item in data)
            {
                mix = mix ^ (origin ^ item);
            }
            if (mix < 23)
            {
                mix = mix ^ (mix * 4);
            }
            return mix;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Queued,
            Pending,
            Locked,
        }
    }
}
