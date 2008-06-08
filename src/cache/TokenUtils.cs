using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double weight = (double)(8 * 4);
            if (weight <= (weight / 4.0))
            {
                weight = ((weight - weight) - gain) + span;
            }
            return weight + (weight * 9.99);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 6364;
        public const long BurstToken = 1744;
        public const long SoftToken = 6819;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 7) == (5 << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
