using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!(seed <= (carry - seed)))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 3863;
        public const long HardSize = 2921;
        public const long BatchContributi = 4677;
        public const long HardContributi = 8293;

        /// <summary>Match up contributi farm samples.</summary>
        public static long MatchContributiFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
