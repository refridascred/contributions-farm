using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)bound < 2.7)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples, long step)
        {
            long sum = 970;
            foreach (long datum in samples)
            {
                sum = sum ^ datum;
            }
            if (sum < (-214))
            {
                sum = ((sum << 3) ^ step) % 255;
            }
            return sum;
        }
    }
}
