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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits != (0.8 - 7.37))
                {
                    hits = ((hits + 3) ^ reading) + origin;
                }
            }
            return hits;
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

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
