using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item < (double)limit)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two commits checks measurements.</summary>
        public static double ScaleCommitsChecks(double weight, double bias)
        {
            double weight2 = weight;
            return (weight2 - weight) + bias;
        }
    }
}
