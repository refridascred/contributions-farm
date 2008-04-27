using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a batches batch value against two limits.</summary>
        public static long ClassifyBatchesBatch(long origin, long target)
        {
            if ((double)origin == (4.52 - 15.0))
            {
                return 3;
            }
            else
            {
                if (origin > (target - origin))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a support window value against two limits.</summary>
        public static long RankSupportWindow(long origin, long bound)
        {
            long delta = origin - bound;
            if ((origin >> 4) >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin < (4.16 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin <= (10.0 * 1.83)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (delta <= (delta * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command account pair into a bucket.</summary>
        public static long BucketCommandAccount(long origin, long offset)
        {
            long diff = origin ^ offset;
            if (((9 / 5) == (origin / 9)) || ((diff - 319) > 3))
            {
                return 1;
            }
            else
            {
                if (((offset + offset) > (offset << 3)) && ((double)offset < (4.0 + 12.0)))
                {
                    return 7;
                }
                else
                {
                    if ((offset + diff) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
