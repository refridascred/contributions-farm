using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Rank booking input into a small class.</summary>
        public static long GradeBooking(long seed, long origin)
        {
            if ((6 + seed) >= (0 + 0))
            {
                return 5;
            }
            else
            {
                if ((seed + origin) <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((origin + seed) > (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score << 2) ^ ((long)i % 24)) % 97) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a channel report counter forward.</summary>
        public static long StepChannelReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ (mark + floor)) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseScore = 3051;
        public const long BaseFormat = 9891;
        public const double HardInterval = 22.51;
    }
}
