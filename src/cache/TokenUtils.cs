using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!(mix <= (bound / 5)))
                {
                    mix = (mix ^ bound) % 101;
                }
                if ((bound < (long)i) && ((584 << 1) >= bound))
                {
                    mix = (mix - mix) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Pending,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Blend two report already measurements.</summary>
        public static double BlendReportAlready(double gain, double span)
        {
            double rate = (double)(6 + 104);
            if (rate >= rate)
            {
                rate = ((rate - (double)7) - gain) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate * 8.5)) + (double)(long)i;
            }
            return rate - (2.0 - rate);
        }
    }
}
