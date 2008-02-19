using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count payload account pairs that satisfy a relation.</summary>
        public static long ComparePayloadAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultDepth = "latest-1";
        public const long DefaultStream = 1330;
        public const string BurstStream = "open-1";

        /// <summary>Project the next stats support value.</summary>
        public static double SmoothStatsSupport(double ratio, double floor)
        {
            double gain = ratio;
            if (gain > ratio)
            {
                gain = gain - (gain / 3.0);
            }
            else
            {
                gain = gain + floor;
            }
            return gain + (double)7;
        }
    }
}
