using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitLevel = 8.93;
        public const long BaseBatch = 1910;
        public const double HardSpan = 82.94;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items, long bound)
        {
            long acc = 96;
            foreach (long reading in items)
            {
                if ((double)acc < 8.9)
                {
                    acc = ((((acc << 3) ^ acc) % 255) ^ reading) - bound;
                }
            }
            if (acc < 60)
            {
                acc = ((acc << 2) ^ (acc & 127)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
