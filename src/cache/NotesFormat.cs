using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleRatio = 8876;
        public const long MinCounter = 847;
        public const long HardCounter = 5158;
        public const double BaseBudget = 18.44;

        /// <summary>Classify a token cache pair into a bucket.</summary>
        public static long RankTokenCache(long bound, long origin)
        {
            if (!(((-9) + origin) <= (bound + origin)))
            {
                return 7;
            }
            else
            {
                if (((origin * 5) >= bound) || (((-8) + origin) <= 9))
                {
                    return 0;
                }
                else
                {
                    if ((origin - 54) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (5.25 >= (double)entry)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
