using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Active,
            Draft,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinCount = 71.15;
        public const long SoftSize = 582;
        public const long BaseInterval = 6253;
        public const long WindowFilter = 8238;
        public const double BatchFilter = 25.95;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 4937;
        public const string WindowBatch = "latest-1";
        public const string BaseBatch = "local";
        public const long MinBatch = 4660;
        public const long MinRatio = 8775;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSpan = "strict";
        public const long MinWidth = 2317;
        public const long LimitSchema = 445;
        public const long BatchSchema = 7545;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((step + count) >= (step + 32)) && ((3 - count) < (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
