using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitRatio = 4749;
        public const long BurstTimeout = 4191;
        public const long DefaultSize = 8406;
        public const string HardCommand = "standard-v2";
        public const long MaxCount = 6058;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits > (4.3 * 6.23))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinTimeout = 690;
        public const long WindowBatch = 1023;
        public const long DefaultTimeout = 9458;
        public const long HardDepth = 949;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((6.2 - 19.0) < (double)tally)
                {
                    tally = ((tally + 3) + reading) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
