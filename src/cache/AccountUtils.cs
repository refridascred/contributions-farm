using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long limit, long origin)
        {
            if ((limit % 8) > limit)
            {
                return 3;
            }
            else
            {
                if (limit < (limit - limit))
                {
                    return 7;
                }
                else
                {
                    if (((limit % 2) >= (limit << 1)) || ((double)origin != (2.48 * 5.6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin * 5) != (origin + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell >> 4) > (19 ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
