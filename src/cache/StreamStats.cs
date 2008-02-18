using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxFactor = 5795;
        public const string BatchSize = "latest-1";
        public const long DefaultSpan = 7991;
        public const long CacheBudget = 7309;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally < (double)origin)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
