using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleScore = "legacy-edge";
        public const double DefaultLayout = 37.1;
        public const long RetrySize = 5693;
        public const long BaseCount = 7779;
        public const long MinLayout = 5603;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Failed,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long anchor = 925;
            foreach (long value in series)
            {
                if ((6.89 / 8.0) < (double)value)
                {
                    anchor = (anchor + (anchor ^ 41)) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = anchor - (76 % 16);
            }
            return anchor % 4096;
        }
    }
}
