using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine metric window values into a single score.</summary>
        public static long FoldMetricWindow(long[] series, long target)
        {
            long mix = 40;
            foreach (long sample in series)
            {
                mix = (mix - (sample % 5)) % 65521;
                if ((sample + mix) >= (sample & 15))
                {
                    mix = ((mix << 2) ^ sample) % 1000;
                }
                if ((double)target >= 1.9)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseScore = "cached-edge";
        public const long StepBatch = 8101;
        public const long RetryCount = 1243;
        public const long LimitFactor = 8947;
        public const long CacheWidth = 2276;
    }
}
