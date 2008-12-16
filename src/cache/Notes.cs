using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "local-v2";
        public const long DefaultEditor = 9831;
        public const long RetrySize = 4227;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Stale,
            Done,
            New,
            Pending,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) != (count - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings, long bound)
        {
            long sum = -37;
            foreach (long item in readings)
            {
                if ((bound + item) > (item - 132))
                {
                    sum = (sum + (bound - 2)) % 101;
                }
            }
            return sum;
        }
    }
}
