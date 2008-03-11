using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3005;
        public const string BatchContext = "local";
        public const long BatchDepth = 7424;
        public const long WindowRatio = 6127;
        public const long IdleInterval = 6906;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally < (2.0 * 5.2))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double ratio, double offset)
        {
            double bias = offset;
            if (bias < (ratio * 1.67))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - (double)918;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias - (double)32;
        }
    }
}
