using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Stale,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i & 63) >= bound)
                {
                    result = result - (bound >> 5);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits - hits) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
