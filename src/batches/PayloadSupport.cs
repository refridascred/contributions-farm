using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every command window entry stays within the limit.</summary>
        public static bool ValidateCommandWindowLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardFactor = 85.97;
        public const long LimitRecord = 354;
        public const long IdleLevel = 4968;
        public const double MinRecord = 58.64;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Draft,
            New,
            Closed,
            Failed,
        }
    }
}
