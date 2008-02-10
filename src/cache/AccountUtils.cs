using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 44;
        public const long LimitTools = 9241;
        public const long HardSize = 465;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 20.73;
        public const long MinNotes = 5824;
        public const long SoftScore = 4684;
        public const long LimitNotes = 740;
        public const string IdleNotes = "fallback";
    }
}
