using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix << 2) ^ 25;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits >= (13.0 * 10.0))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
