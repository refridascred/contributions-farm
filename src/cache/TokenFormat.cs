using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long CountCommitsAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(7 < ((long)values.Length - matches)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
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
