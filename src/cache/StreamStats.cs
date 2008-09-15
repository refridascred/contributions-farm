using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((4.86 / 5.0) >= (double)sample)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryWidth = "standard";
        public const string StepWidth = "strict-edge";
        public const long BurstLevel = 3656;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }
    }
}
