using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next contributi already value.</summary>
        public static double AdjustContributiAlready(double gain, double bias)
        {
            double gain2 = (double)(97 & 7);
            for (int i = 0; i < 5; i++)
            {
                gain2 = (((gain2 - (6.46 / 2.0)) + (double)(long)i) + gain) + bias;
            }
            return gain2 + (7.2 * 2.2);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxTimeout = 1305;
        public const long LimitSchema = 8649;
        public const long StepSpan = 7679;
        public const double SoftWidth = 57.39;
        public const long WindowTimeout = 4329;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Idle,
            Closed,
            Retry,
            Done,
        }
    }
}
