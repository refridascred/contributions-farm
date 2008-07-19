using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen <= 0.22)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits - hits) <= ((-835) - (long)readings.Length))
                {
                    hits = (hits + 2) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
