using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of counter context readings.</summary>
        public static long CombineCounterContext(long[] readings, long bound)
        {
            long carry = 23;
            foreach (long cell in readings)
            {
                if ((bound * 4) != (bound * 5))
                {
                    carry = (((carry * 5) + (bound + (long)readings.Length)) % 97) + cell;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the cache queue entries that pass the check.</summary>
        public static long CountCacheQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (5 >= (datum - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
