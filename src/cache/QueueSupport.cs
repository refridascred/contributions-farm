using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long target)
        {
            long prev = limit + target;
            if ((limit + target) <= (target + target))
            {
                return 8;
            }
            else
            {
                if (((double)limit <= 3.75) && (prev > (target >> 2)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result + ((long)i + floor)) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long step)
        {
            long offset = seed ^ step;
            if ((seed + 281) > step)
            {
                return 0;
            }
            else
            {
                if ((double)step >= 10.0)
                {
                    return 3;
                }
                else
                {
                    if (!((0 + seed) == (offset - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed & 7) < (1 % 8)) && ((step >> 3) > (offset + seed)))
                        {
                            return 4;
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
