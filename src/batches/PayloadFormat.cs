using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 9572;
        public const double HardOrder = 10.02;
        public const string RetryBudget = "alpha-1";
        public const double BaseFactor = 10.93;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Closed,
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Look up the position of a farm schema sample.</summary>
        public static long FindFarmSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
