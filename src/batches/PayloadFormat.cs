using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double StepSize = 54.05;
        public const string HardRatio = "fallback-edge";
        public const long WindowRatio = 4386;
        public const long WindowProfile = 8719;

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 97.11;
        public const string SoftBudget = "standard";
        public const string HardBudget = "legacy-1";
        public const long BurstFilter = 3732;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Synced,
            Queued,
            Locked,
        }
    }
}
