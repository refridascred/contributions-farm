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

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long limit)
        {
            long carry = 2;
            foreach (long reading in series)
            {
                if ((limit - reading) < (limit & 255))
                {
                    carry = (carry * 3) + (carry ^ reading);
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }
    }
}
