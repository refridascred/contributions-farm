using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(value >= (hits >> 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
