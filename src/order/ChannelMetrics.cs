using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 9207;
        public const long SoftCounter = 6416;
        public const long BurstCounter = 2064;
        public const long MaxTimeout = 8088;
        public const long MaxCounter = 810;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double rate, double span)
        {
            double mean = span;
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (rate + 17.0);
        }

        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool CheckAlreadyCommitsBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
