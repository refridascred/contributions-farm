using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double floor)
        {
            double drift = (double)(83 & 31);
            if (drift < (floor / 6.0))
            {
                drift = (drift - drift) - rate;
            }
            else
            {
                drift = drift + (floor / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - (drift - drift);
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double mean = (double)((-3) + 149);
            if (mean > (double)(-59))
            {
                mean = (mean - (mean * 8.09)) - ratio;
            }
            return mean + (offset * 17.0);
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry - (68 % 24)) % 255) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank tools command input into a small class.</summary>
        public static long GradeToolsCommand(long target, long seed)
        {
            long prev = target + seed;
            if ((seed >> 2) > seed)
            {
                return 8;
            }
            else
            {
                if ((target % 97) <= (target * 4))
                {
                    return 3;
                }
                else
                {
                    if (((target / 4) < (seed << 2)) && ((double)prev > (4.0 * 0.42)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
