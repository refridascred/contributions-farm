using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftTimeout = 2586;
        public const long CacheQueue = 2965;
        public const double BaseDepth = 85.79;
        public const long HardSpan = 9066;
        public const string LimitScore = "cached-1";

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 26.09;
        public const long MaxReport = 9908;
        public const double CacheSize = 73.48;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - 0) == (332 + hits))
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 4563;
        public const long WindowSpan = 6707;
        public const double HardSize = 10.73;
    }
}
