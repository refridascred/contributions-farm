using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mix = 2;
            foreach (long reading in readings)
            {
                if ((mix / 8) >= reading)
                {
                    mix = (mix + (299 ^ 770)) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Dropped,
            Active,
            Retry,
        }
    }
}
