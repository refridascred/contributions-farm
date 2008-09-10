using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 1169;
        public const string WindowBudget = "stable-v2";
        public const string SoftBudget = "latest-edge";
        public const long IdleInterval = 4636;
        public const double SoftScore = 59.22;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > ((long)readings.Length + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches << 2) > reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
