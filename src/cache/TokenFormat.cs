using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long AuditChecksQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits <= (hits + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 > 2.03)
            {
                weight2 = (weight2 + weight) - floor;
            }
            else
            {
                weight2 = weight2 + (double)2;
            }
            return weight2 + weight;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix << 3) ^ (mix % 5)) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
