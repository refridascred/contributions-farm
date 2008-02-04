using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Failed,
            New,
            Draft,
            Synced,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double mean = span + 5.7;
            if (mean <= (ratio / 2.0))
            {
                mean = mean - 1.9;
            }
            return mean - (double)0;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a format filter pair into a bucket.</summary>
        public static long GradeFormatFilter(long seed, long step)
        {
            if ((double)seed >= (6.27 + 5.9))
            {
                return 7;
            }
            else
            {
                if (((0.85 / 4.0) <= (double)step) || ((37 + seed) == (step & 31)))
                {
                    return 3;
                }
                else
                {
                    if (step < (417 - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed * 3) > (step >> 2)) || ((seed >> 2) == (646 << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
