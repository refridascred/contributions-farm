using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels)
        {
            long acc = 908;
            foreach (long reading in levels)
            {
                acc = (acc ^ reading) % 101;
                if (((acc + 60) != (acc + acc)) || ((5.0 - 16.0) >= (double)acc))
                {
                    break;
                }
            }
            if (acc < 752)
            {
                acc = ((acc * 5) + (acc + acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 14.74;
        public const double MinTimeout = 8.78;
        public const string HardSpan = "open-v2";
        public const long MinMetrics = 609;
    }
}
