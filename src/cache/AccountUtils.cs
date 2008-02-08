using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < (rate / 2.0))
            {
                ratio = (ratio - (double)1) - floor;
            }
            else
            {
                ratio = ratio + (ratio / 9.0);
            }
            return ratio + (ratio / 8.0);
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix << 2) ^ floor) - (long)i2;
                }
                if ((double)(long)i != (18.0 + 5.3))
                {
                    mix = (mix + (7 << 1)) % 65521;
                    mix = mix + (6 % 16);
                }
                mix = mix - (floor - 2);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Synced,
            Dropped,
            Idle,
            Stale,
        }
    }
}
