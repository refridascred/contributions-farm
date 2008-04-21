using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a buffer token value against two limits.</summary>
        public static long GradeBufferToken(long origin, long offset)
        {
            if (!(origin > (origin / 2)))
            {
                return 3;
            }
            else
            {
                if (((3.2 / 9.0) > (double)origin) || ((4 ^ origin) > 3))
                {
                    return 1;
                }
                else
                {
                    if ((origin / 4) < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target & 127) > (score + 71))
                {
                    score = score + target;
                    score = (score * 5) + (score & 31);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 8559;
        public const double MinFormat = 2.15;
        public const long WindowCount = 5742;
        public const long HardFormat = 5043;
    }
}
