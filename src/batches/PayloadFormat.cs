using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double HardLevel = 90.96;
        public const long DefaultWindow = 8121;
        public const double CacheWindow = 3.15;
        public const double IdleWindow = 86.82;
        public const string MinFactor = "alpha-v2";

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Active,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long step, long step2)
        {
            if (!((step2 - step2) > step2))
            {
                return 7;
            }
            else
            {
                if (!((double)step == (2.39 - 13.0)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
