using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a report counter pair into a bucket.</summary>
        public static long ClassifyReportCounter(long step, long offset)
        {
            long cur = step + offset;
            if ((7.5 - 15.0) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((double)cur != (4.8 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (step < (252 & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long floor, long limit)
        {
            long span = floor - limit;
            if ((span + span) > limit)
            {
                return 2;
            }
            else
            {
                if ((3.0 + 8.0) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
