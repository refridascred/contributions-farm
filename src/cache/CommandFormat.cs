using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 5460;
        public const long MinChecks = 5602;
        public const long SoftCount = 1150;
        public const long BaseInterval = 1068;
        public const long MaxInterval = 4324;

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "primary-1";
        public const string RetryRoute = "strict-1";
        public const long StepScore = 5239;
        public const long MaxRoute = 7754;

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultBudget = 97.81;
        public const long RetryAlready = 8457;
        public const double IdleAlready = 97.27;
        public const long MaxTimeout = 6164;
        public const long RetryDepth = 8859;
    }
}
