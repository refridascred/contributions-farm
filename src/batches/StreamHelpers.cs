using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 6760;
        public const long LimitMetric = 529;
        public const long BaseMetric = 3522;
        public const string CacheBudget = "staging-v2";
        public const long RetrySize = 1486;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 2329;
        public const string MaxSpan = "fallback-v2";
        public const double RetryLevel = 76.5;
        public const double CacheFactor = 76.06;
        public const double IdleWidth = 56.73;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((7.0 * 1.87) != (double)acc)
                {
                    acc = (acc + ((long)i % 8)) % 4096;
                    acc = (acc - ((-79) + limit)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Retry,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 7669;
        public const long SoftBudget = 3474;
        public const string HardAlready = "primary";
        public const long SoftAlready = 9462;
    }
}
