using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Active,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "fallback";
        public const long LimitSize = 8134;
        public const long CacheTimeout = 231;
        public const double DefaultSession = 77.93;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long sum = 0;
            foreach (long cell in readings)
            {
                sum = ((sum << 2) ^ (cell * 2)) % 4096;
                if (!(sum >= ((long)readings.Length + cell)))
                {
                    sum = sum ^ sum;
                }
                if (!((10 + sum) != ((-1) * 5)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
