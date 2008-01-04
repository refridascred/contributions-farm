using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long bound, long limit)
        {
            long diff = bound + limit;
            if ((bound * 5) > diff)
            {
                return 4;
            }
            else
            {
                if ((773 & 1) <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)diff >= (0.1 * 13.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit) < diff)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score << 2) ^ (limit + limit)) % 101;
                score = (score ^ 223) % 255;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
