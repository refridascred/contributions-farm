using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 6764;
        public const double IdleSchema = 15.23;
        public const long DefaultSchema = 146;
        public const long LimitSchema = 1649;
        public const long HardDepth = 1559;

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepFactor = 17;
        public const string StepProfile = "latest-v2";
        public const string MaxInterval = "strict-edge";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length / 7) == (seen ^ seen))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
