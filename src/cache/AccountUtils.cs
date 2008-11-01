using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 9846;
        public const long SoftRoute = 455;
        public const double WindowScore = 34.56;

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long step2)
        {
            long lane = step + step2;
            if ((7.0 + 9.0) == (double)step)
            {
                return 5;
            }
            else
            {
                if ((lane >= (step & 63)) && ((double)step >= 3.62))
                {
                    return 8;
                }
                else
                {
                    if ((double)717 < (double)lane)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((0 >> 5) == ((-324) + step2)) && ((double)step2 < (double)84))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
