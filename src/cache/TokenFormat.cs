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

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double load = floor;
            if (load > (scale * 18.0))
            {
                load = load + (floor - load);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (scale - floor)) + (double)(long)i;
            }
            return load + scale;
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
