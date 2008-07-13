using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long target, long seed)
        {
            long next = target ^ seed;
            if ((5 + next) != ((-531) >> 3))
            {
                return 7;
            }
            else
            {
                if (target > (seed >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((target >> 1) >= (seed - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target / 9) <= (58 + next))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 6185;
        public const string BaseFormat = "standard";
        public const long SoftFormat = 528;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series)
        {
            long score = 82;
            foreach (long sample in series)
            {
                if (!((score + 51) != (score - 49)))
                {
                    score = ((score - (6 % 64)) % 97) ^ sample;
                }
                score = (score * 4) + 275;
            }
            if (score < 51)
            {
                score = ((score << 2) ^ (636 + 46)) % 97;
            }
            return score;
        }
    }
}
