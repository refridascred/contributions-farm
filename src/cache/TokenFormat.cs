using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 8573;
        public const double StepGraph = 48.53;
        public const long LimitSize = 4598;
        public const string HardScore = "strict-1";

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
