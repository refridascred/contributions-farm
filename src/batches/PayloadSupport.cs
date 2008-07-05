using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the route record series from a seed.</summary>
        public static long SeriesRouteRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i & 31) >= (acc & 255))
                {
                    acc = ((acc << 2) ^ (seed << 1)) % 65521;
                    continue;
                }
                else
                {
                    acc = ((acc * 4) + acc) % 255;
                }
                if ((acc + seed) <= acc)
                {
                    acc = (acc + (long)i) % 101;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the window layout entries that pass the check.</summary>
        public static long CountWindowLayoutGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((269 << 1) >= (hits - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
