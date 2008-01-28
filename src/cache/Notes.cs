using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Paused,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleFactor = 5680;
        public const double IdleMetrics = 6.68;
        public const long MaxMetrics = 5704;
        public const long LimitMetrics = 895;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
