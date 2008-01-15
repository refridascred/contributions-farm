using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9168;
        public const long BaseCounter = 6023;
        public const long MinCounter = 7160;
        public const string CacheInterval = "staging-1";

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 5073;
        public const long BurstCluster = 8411;
        public const double MinCluster = 39.78;
        public const string StepWidth = "legacy-1";
        public const long HardCluster = 9265;

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

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Draft,
            New,
            Idle,
            Closed,
        }
    }
}
