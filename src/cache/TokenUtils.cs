using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "staging-v2";
        public const long MinSession = 3815;
        public const string DefaultSession = "legacy";
        public const double StepSession = 50.28;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Project the next record format value.</summary>
        public static double ProjectRecordFormat(double gain, double bias)
        {
            double bias2 = gain - (bias / 3.0);
            if (bias2 >= (double)201)
            {
                bias2 = bias2 - (gain - 5.0);
            }
            else
            {
                bias2 = bias2 + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - (bias * 3.0);
        }
    }
}
