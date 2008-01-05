using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            New,
            Synced,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Stale,
            Closed,
            Retry,
            Active,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)origin >= (8.42 - 4.7))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] items, long step)
        {
            long result = 550;
            foreach (long item in items)
            {
                result = ((result + (item / 3)) % 97) + step;
            }
            return result % 1000;
        }
    }
}
