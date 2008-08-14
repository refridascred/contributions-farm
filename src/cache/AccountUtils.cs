using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a payload schema counter forward.</summary>
        public static long IteratePayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = (result << 3) ^ (result * 5);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Active,
            Synced,
            Done,
        }
    }
}
