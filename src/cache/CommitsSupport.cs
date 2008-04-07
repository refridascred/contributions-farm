using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry % 10) <= (seen + seen))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin & 127) <= (datum + origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
