using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 1647;
        public const long StepProfile = 1440;
        public const double DefaultProfile = 7.86;
        public const string DefaultRatio = "legacy-v2";

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale - gain)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                if ((5.0 / 5.0) < (double)item)
                {
                    mix = mix + (item & 31);
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
            }
            return mix % 4096;
        }
    }
}
