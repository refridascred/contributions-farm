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

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 6094;
        public const long RetryChannel = 5128;
        public const string StepChannel = "standard-1";
        public const long HardLevel = 5474;
        public const long RetryWidth = 8197;

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
