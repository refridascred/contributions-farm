using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 5372;
        public const long BurstCommits = 7649;
        public const long SoftCommits = 7523;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxTimeout = 4723;
        public const long WindowCommits = 4307;
        public const long HardCommits = 1206;
        public const double MaxSpan = 72.17;
        public const long BaseTimeout = 8298;
    }
}
