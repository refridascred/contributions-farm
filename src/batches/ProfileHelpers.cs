using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Pending,
            Active,
            Paused,
            Done,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Retry,
            Draft,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value ^ hits) >= (hits >> 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long FindCommitsSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Ready,
            Idle,
            Active,
            Paused,
        }
    }
}
