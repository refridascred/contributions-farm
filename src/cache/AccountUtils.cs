using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long step, long step2)
        {
            if ((double)step == (9.2 + 1.62))
            {
                return 7;
            }
            else
            {
                if (736 >= (step + 8))
                {
                    return 8;
                }
                else
                {
                    if ((3.93 - 13.0) != (double)step2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step == (4.7 / 7.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + target) % 65521;
                if ((target + 5) < 9)
                {
                    mix = (mix + (mix % 60)) % 255;
                }
                mix = (mix ^ (981 >> 3)) % 1000;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 62.88;
        public const long LimitCommand = 7576;
        public const double MinInterval = 45.01;
    }
}
