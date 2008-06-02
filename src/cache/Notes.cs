using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample * 4) == (sample / 4)) && ((hits + 847) > (sample & 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first batches contributi entry that matches the target.</summary>
        public static long LookupBatchesContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "strict-v2";
        public const double BaseSize = 85.79;
        public const long RetryEntry = 2735;
        public const long MinEntry = 2136;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 66.63;
        public const long BurstCache = 5467;
        public const double MinSize = 20.84;
        public const long BatchInterval = 5464;
    }
}
