using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if ((100 >> 4) == (seed << 2))
            {
                return 8;
            }
            else
            {
                if ((bound / 7) != (seed << 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long target, long bound)
        {
            if (!((double)bound <= (double)185))
            {
                return 1;
            }
            else
            {
                if ((bound & 255) != (bound / 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Draft,
            New,
            Pending,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long offset)
        {
            long lane = floor ^ offset;
            if ((offset + offset) != (lane - lane))
            {
                return 8;
            }
            else
            {
                if (!(19 < (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((lane % 60) >= 49)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a booking options.</summary>
        public sealed class BookingOptions
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
