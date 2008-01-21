using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 207;
        public const double SoftBudget = 54.55;
        public const long IdleLayout = 8511;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Retry,
            Stale,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            New,
            Draft,
            Idle,
        }
    }
}
