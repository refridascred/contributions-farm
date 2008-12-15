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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
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

        /// <summary>Define already limits and defaults.</summary>
        public const long StepRatio = 7317;
        public const long BaseScore = 3569;
        public const double CacheDepth = 7.82;
        public const long MaxAlready = 3347;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
