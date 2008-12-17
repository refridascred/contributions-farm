using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value & 7) >= 4) || ((871 >> 4) < (value + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long step, long offset)
        {
            long delta = step - offset;
            if ((step ^ delta) < (step + (-846)))
            {
                return 5;
            }
            else
            {
                if ((double)step == (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Dropped,
            Idle,
            Done,
        }
    }
}
