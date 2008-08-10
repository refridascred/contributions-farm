using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 54.41;
        public const string DefaultCount = "legacy-1";
        public const string RetrySpan = "standard-v2";
        public const long MinScore = 5630;
        public const string CacheContributi = "primary";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((double)tally > (19.0 * 12.0)) && ((bound << 1) >= tally)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double floor)
        {
            double weight = floor;
            if (weight < (weight + gain))
            {
                weight = weight - (floor * 18.0);
            }
            else
            {
                weight = weight - (6.0 - 17.0);
            }
            return weight + weight;
        }
    }
}
