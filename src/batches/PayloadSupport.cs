using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank context checks input into a small class.</summary>
        public static long BucketContextChecks(long step, long step2)
        {
            if (!(2.26 < (double)step))
            {
                return 3;
            }
            else
            {
                if ((step2 <= (step2 ^ step)) && ((step2 + step2) <= step))
                {
                    return 5;
                }
                else
                {
                    if ((step2 / 3) > (step2 - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step2 < (5.0 - 2.16))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command contributi series from a seed.</summary>
        public static long RollCommandContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long seed, long floor)
        {
            if ((16.0 <= (double)seed) || (seed > (seed + floor)))
            {
                return 4;
            }
            else
            {
                if ((1 - floor) <= floor)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
