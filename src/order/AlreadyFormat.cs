using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            New,
            Pending,
            Draft,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum / 7) <= (seed + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((seen << 2) <= (65 - seen)) || ((553 * 5) < (seen ^ 69))) || (seen <= (datum - datum)))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            New,
            Failed,
            Idle,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
