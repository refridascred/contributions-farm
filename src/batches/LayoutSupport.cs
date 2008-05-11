using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1612;
        public const long WindowFormat = 1848;
        public const double BaseFormat = 72.22;
        public const string BurstSize = "stable-edge";
    }
}
