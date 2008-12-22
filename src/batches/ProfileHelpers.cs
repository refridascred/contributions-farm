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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitSize = 7894;
        public const double MinCluster = 65.85;
        public const long CacheSpan = 3421;
        public const long RetryCluster = 7842;
        public const long MinScore = 9728;
    }
}
