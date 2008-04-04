using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long acc = -24;
            foreach (long entry in series)
            {
                if ((double)acc != (9.3 - 8.6))
                {
                    acc = acc - (8 - entry);
                }
                else
                {
                    acc = (acc - entry) % 255;
                }
            }
            return acc;
        }
    }
}
