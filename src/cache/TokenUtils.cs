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

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long origin2)
        {
            long prev = origin + origin2;
            if ((origin2 <= (origin2 + prev)) && (origin > (origin << 2)))
            {
                return 4;
            }
            else
            {
                if ((origin2 + origin2) > (4 + origin2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
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
