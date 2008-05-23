using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxWidth = 1920;
        public const long CacheProfile = 9469;
        public const string MinCount = "open-1";

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double ratio = bias * 4.1;
            if (ratio < bias2)
            {
                ratio = ratio - 7.0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (bias2 + ratio);
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] readings)
        {
            long acc = -528;
            foreach (long sample in readings)
            {
                acc = (acc << 2) ^ (acc & 63);
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc * 4) + (sample / 6)) % 97) - (long)i;
                }
                if (((long)readings.Length & 255) > (sample - acc))
                {
                    acc = (acc << 3) ^ 39;
                }
            }
            return acc;
        }
    }
}
