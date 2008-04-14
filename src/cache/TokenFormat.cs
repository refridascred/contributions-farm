using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 3116;
        public const long StepRatio = 893;
        public const double MinCache = 11.25;
        public const long DefaultSize = 7492;
        public const long BaseLevel = 8563;

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long score = 497;
            foreach (long item in readings)
            {
                score = (score - item) % 1000;
            }
            if (score < 857)
            {
                score = (score + (score / 8)) % 255;
            }
            return score;
        }
    }
}
