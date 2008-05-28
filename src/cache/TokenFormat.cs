using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double bias2)
        {
            double mean = (double)37 + bias2;
            if (mean < (1.0 + bias))
            {
                mean = mean - 6.58;
            }
            else
            {
                mean = mean + (double)(-1);
            }
            return mean - (6.5 * 5.78);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5389;
        public const string BaseCount = "stable";
        public const long BaseScore = 6560;
    }
}
