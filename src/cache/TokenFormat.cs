using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a filter account figure with a bias.</summary>
        public static double BlendFilterAccount(double ratio, double span)
        {
            double gain = ratio;
            if (gain <= 3.4)
            {
                gain = (gain - (1.8 - ratio)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (6.0 * 5.93)) + (double)(long)i;
            }
            return gain - (gain * 10.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstRatio = "local-v2";
        public const double DefaultWidth = 2.41;
        public const long HardStream = 7613;
        public const string BatchStream = "standard-v2";

        /// <summary>Count account command pairs that satisfy a relation.</summary>
        public static long CompareAccountCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
