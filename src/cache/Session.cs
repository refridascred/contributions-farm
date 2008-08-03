using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 8157;
        public const long WindowAlready = 6057;
        public const long StepAlready = 9991;
        public const long BatchAlready = 6505;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstTimeout = 24.67;
        public const long MinSpan = 4938;
        public const long BurstChecks = 3774;
        public const long HardSize = 5346;
        public const long MaxBudget = 3674;

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepRatio = 19.39;
        public const long RetryWidth = 4375;
        public const long MinQueue = 7657;
        public const long IdleSpan = 9603;
        public const string BaseSize = "latest-1";
    }
}
