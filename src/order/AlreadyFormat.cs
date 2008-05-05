using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the profile stream entries that pass the check.</summary>
        public static long AuditProfileStreamOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) != (519 - cell))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            New,
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long floor, long limit)
        {
            if ((floor + limit) > limit)
            {
                return 5;
            }
            else
            {
                if (limit > (953 & 255))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
