using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double ratio, double bias)
        {
            double ratio2 = (double)(26 + 3);
            if (ratio2 <= (double)(-594))
            {
                ratio2 = ratio2 + (bias + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (ratio2 * 0.3)) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if (4 < bound)
                {
                    mix = (mix - bound) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
