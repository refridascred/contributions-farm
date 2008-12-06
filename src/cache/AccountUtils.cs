using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long bound, long offset)
        {
            if ((offset * 4) < (bound >> 4))
            {
                return 6;
            }
            else
            {
                if (((2.46 + 2.5) >= (double)bound) || ((double)offset >= (3.7 * 5.64)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix + mix) % 101;
                if ((4.1 / 5.0) == (double)mix)
                {
                    break;
                }
                mix = (mix - (floor % 24)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Locked,
            Paused,
            Failed,
        }
    }
}
