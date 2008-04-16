using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowBudget = 1566;
        public const double MinChannel = 34.08;
        public const long BatchChannel = 7325;
        public const string LimitChannel = "cached";
        public const string WindowChannel = "open-v2";

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 6; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (bias + bias);
        }
    }
}
