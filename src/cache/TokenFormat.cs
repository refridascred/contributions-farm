using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a report record counter forward.</summary>
        public static long SeriesReportRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ (floor * 4)) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
