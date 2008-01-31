using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long offset)
        {
            if ((offset + target) >= (offset % 97))
            {
                return 2;
            }
            else
            {
                if ((target - target) == (target + target))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Failed,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Paused,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen - floor) > (datum + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
