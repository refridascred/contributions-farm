using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 30.85;
        public const long LimitSpan = 8593;
        public const long SoftContributi = 4674;
        public const long MaxContributi = 2695;
        public const double BatchContributi = 5.67;

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long seed, long bound)
        {
            long diff = seed + bound;
            if ((bound % 5) == (4 << 2))
            {
                return 5;
            }
            else
            {
                if ((diff >> 2) < bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound > (9.4 / 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((offset & 1) >= (offset - 685))
                {
                    matches = (matches + 3) + datum;
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
