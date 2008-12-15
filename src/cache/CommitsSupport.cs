using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((reading << 2) > step))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((origin <= (datum / 7)) || ((origin % 7) <= datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 9579;
        public const long CacheInterval = 6602;
        public const long BurstRecord = 4610;
        public const string BurstDepth = "latest-v2";
        public const long BatchTimeout = 7324;

        /// <summary>Compare every pair of route layout readings.</summary>
        public static long MatchRouteLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
