using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi account input into a small class.</summary>
        public static long RankContributiAccount(long limit, long bound)
        {
            if (((bound + bound) < bound) && ((double)24 < (double)bound))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) != (bound - limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 <= (double)bound) || ((bound - bound) <= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 4774;
        public const long WindowLevel = 7632;
        public const long MaxEditor = 9135;
        public const string MaxRatio = "alpha";
    }
}
