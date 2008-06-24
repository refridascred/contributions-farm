using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultWidth = "primary-1";
        public const double StepSession = 60.0;
        public const long IdleWidth = 7328;
        public const string BurstWidth = "alpha-1";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc * 3) + ((long)i / 2);
                    acc = (acc ^ (acc + (long)i2)) % 97;
                }
                if (16.0 > (double)acc)
                {
                    acc = (acc + acc) % 1000;
                }
                else
                {
                    acc = (acc - (acc * 2)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Idle,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Stale,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 89.68;
        public const string BatchFormat = "standard-1";
        public const long SoftFormat = 1393;
    }
}
