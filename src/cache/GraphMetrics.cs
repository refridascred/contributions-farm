using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "staging-v2";
        public const long DefaultInterval = 9705;
        public const long DefaultLayout = 5901;
        public const long BaseTimeout = 7727;
        public const string SoftRatio = "legacy-edge";

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
