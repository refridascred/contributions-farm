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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = (score - ((-267) & 63)) % 97;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
