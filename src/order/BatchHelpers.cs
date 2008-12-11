using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a support account figure with a bias.</summary>
        public static double ProjectSupportAccount(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < weight)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)15) - (double)(long)i;
            }
            return ratio - (double)925;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinDepth = 1988;
        public const long StepDepth = 8426;
        public const long SoftEntry = 3004;
        public const string BatchTimeout = "legacy-v2";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
