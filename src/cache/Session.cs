using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits << 3) <= (hits % 16))
                {
                    hits = ((hits + 3) + value) - target;
                }
            }
            return hits;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if (((seed2 >> 2) >= (seed & 3)) && (prev < (prev >> 5)))
            {
                return 7;
            }
            else
            {
                if (((seed & 31) == (prev ^ seed)) || ((prev * 2) < 39))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
