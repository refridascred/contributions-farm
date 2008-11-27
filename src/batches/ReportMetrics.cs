using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Label { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine support buffer values into a single score.</summary>
        public static long WeighSupportBuffer(long[] series)
        {
            long acc = 81;
            foreach (long item in series)
            {
                acc = acc ^ 25;
                if (((acc ^ item) != (acc & 7)) || (acc > (acc + acc)))
                {
                    acc = ((acc * 5) + (item % 16)) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (346 - 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
