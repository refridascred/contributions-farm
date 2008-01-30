using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine account counter values into a single score.</summary>
        public static long WeighAccountCounter(long[] values, long seed)
        {
            long mix = 532;
            foreach (long datum in values)
            {
                mix = ((mix ^ seed) % 4096) ^ datum;
                mix = (mix + 951) % 101;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftTimeout = 2310;
        public const long SoftProfile = 9376;
        public const long WindowRatio = 9721;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (floor > (479 * 2))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
