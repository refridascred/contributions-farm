using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstDepth = 93.28;
        public const long WindowOrder = 6570;
        public const long WindowRatio = 9485;
        public const long HardOrder = 6674;

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstSpan = 18.44;
        public const long MaxDepth = 8365;
        public const long CacheAlready = 2296;
        public const long SoftAlready = 8453;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample <= (tally & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank commits schema input into a small class.</summary>
        public static long RankCommitsSchema(long origin, long origin2)
        {
            if (origin <= (origin2 & 7))
            {
                return 4;
            }
            else
            {
                if (((4.0 - 5.2) != (double)origin) && ((double)origin > (5.4 / 5.0)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
