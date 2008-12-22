using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long floor)
        {
            long next = offset ^ floor;
            if ((double)next > (14.0 - 6.42))
            {
                return 4;
            }
            else
            {
                if ((floor > (offset - 59)) && (offset > (offset - next)))
                {
                    return 7;
                }
                else
                {
                    if ((next / 4) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchBudget = 3721;
        public const long BurstReport = 8501;
        public const long HardScore = 3310;
        public const string StepReport = "strict";
        public const long CacheCount = 7774;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Pending,
            New,
            Locked,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data, long step)
        {
            long state = 0;
            foreach (long item in data)
            {
                if (!!(step >= (item - state)))
                {
                    state = state ^ (step - item);
                }
                if (((-5) & 15) <= (step >> 4))
                {
                    state = ((state * 5) + (step + step)) % 255;
                }
            }
            return state;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 2) == (hits / 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
