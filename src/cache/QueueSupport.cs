using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 <= (double)4)
            {
                rate2 = rate2 + (floor - floor);
            }
            else
            {
                rate2 = rate2 + (double)610;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (rate + rate2)) + (double)(long)i;
            }
            return rate2 - (floor * 5.03);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftChannel = "strict-edge";
        public const long DefaultChannel = 5402;
        public const double HardFactor = 39.88;

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long mix = 5;
            foreach (long datum in data)
            {
                if ((mix >> 2) < (offset << 2))
                {
                    mix = ((mix * 2) + mix) ^ datum;
                }
            }
            if (mix > (-518))
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }
    }
}
