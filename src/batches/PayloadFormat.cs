using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Done,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleInterval = 95.03;
        public const long WindowBudget = 8640;
        public const long IdleWidth = 9313;

        /// <summary>Find the first account stats entry that matches the target.</summary>
        public static long SeekAccountStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Closed,
            Ready,
            Retry,
            Synced,
        }
    }
}
