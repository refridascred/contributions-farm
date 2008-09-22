using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Failed,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinBudget = 5168;
        public const long IdleInterval = 7512;
        public const string DefaultSession = "stable-edge";
        public const double MinSession = 36.66;
        public const long WindowScore = 1223;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Retry,
            Locked,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double weight, double floor)
        {
            double mean = weight;
            if (mean < floor)
            {
                mean = mean + (weight - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean - mean)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
