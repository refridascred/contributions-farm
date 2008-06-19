using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double bias)
        {
            double gain = (double)1;
            if (gain > 3.01)
            {
                gain = gain - 6.6;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (double)219) + (double)(long)i;
            }
            return gain - (bias + ratio);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 1287;
        public const long BatchCounter = 8540;
        public const long MinBudget = 5444;
        public const long WindowDepth = 1840;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "strict-v2";
        public const string BaseFactor = "primary";
        public const long BurstTimeout = 4432;
    }
}
