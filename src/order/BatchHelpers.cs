using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count != (double)71)
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Token { get; set; }
            public double Region { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
