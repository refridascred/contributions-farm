using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 9721;
        public const long WindowRatio = 3690;
        public const long BurstNotes = 2954;
        public const long BurstDepth = 2585;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
