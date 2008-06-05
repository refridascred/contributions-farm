using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate filter batches readings against a bound.</summary>
        public static bool VerifyFilterBatchesBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long origin)
        {
            if (((origin - target) != (origin ^ origin)) && ((3.6 / 2.0) == (double)target))
            {
                return 1;
            }
            else
            {
                if ((target - origin) > (origin & 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank record format input into a small class.</summary>
        public static long GradeRecordFormat(long offset, long floor)
        {
            if (12.0 < (double)offset)
            {
                return 6;
            }
            else
            {
                if ((floor - offset) == (floor & 15))
                {
                    return 1;
                }
                else
                {
                    if ((offset < (447 + offset)) || ((floor - offset) != (floor >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
