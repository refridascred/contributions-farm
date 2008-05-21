using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long limit2)
        {
            if ((17 >> 1) <= (limit % 100))
            {
                return 8;
            }
            else
            {
                if (((8 - limit) <= (limit2 + (-7))) || ((-4) >= limit2))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit == (7.82 - 5.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit) == (865 + limit2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long target, long limit)
        {
            if ((double)limit <= 9.36)
            {
                return 7;
            }
            else
            {
                if (!((double)target >= (3.24 / 3.0)))
                {
                    return 5;
                }
                else
                {
                    if ((target & 31) == (81 ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit * 2) <= (limit - target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
