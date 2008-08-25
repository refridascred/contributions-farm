using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 3759;
        public const long RetryFactor = 7536;
        public const string BurstRatio = "cached-v2";
        public const long HardProfile = 2647;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((limit * 5) >= 66)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
