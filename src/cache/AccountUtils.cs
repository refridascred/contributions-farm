using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "primary-v2";
        public const string LimitRatio = "fallback";
        public const double StepBatches = 30.77;
        public const double SoftBatches = 75.3;
        public const long HardBatches = 7205;

        /// <summary>Project the next editor contributi value.</summary>
        public static double ScaleEditorContributi(double weight, double bias)
        {
            double weight2 = (double)(8 % 64);
            if (weight2 <= (weight2 * 16.0))
            {
                weight2 = (weight2 + (weight2 / 2.0)) - weight;
            }
            else
            {
                weight2 = weight2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (bias / 5.0)) - (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long bound)
        {
            if ((offset & 127) <= (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((bound % 100) < (offset - 632))
                {
                    return 6;
                }
                else
                {
                    if ((8 * 5) > (offset - 812))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
