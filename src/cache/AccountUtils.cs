using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFactor = 62.67;
        public const long MinBudget = 8055;
        public const long StepFarm = 3818;
        public const long DefaultWidth = 403;
        public const double BaseScore = 81.63;

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "staging-v2";
        public const string IdleInterval = "strict-v2";
        public const long IdleSession = 9896;

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double load = ratio;
            if (load <= 4.65)
            {
                load = (load - (double)421) + offset;
            }
            return load - load;
        }
    }
}
