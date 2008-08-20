using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultWidth = 2396;
        public const double WindowSize = 68.15;
        public const long MinCount = 9452;
        public const string HardGraph = "open-v2";
        public const double CacheSize = 52.55;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((8.73 * 2.5) <= (double)matches) && (((5.98 * 6.5) == (double)reading) && (matches < (reading % 8))))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
