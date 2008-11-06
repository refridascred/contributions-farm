using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long offset, long limit)
        {
            if ((double)limit > (5.0 + 3.9))
            {
                return 6;
            }
            else
            {
                if (!((9 / 2) == (limit - offset)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a checks batches value against two limits.</summary>
        public static long BucketChecksBatches(long offset, long target)
        {
            if ((1.7 - 7.0) > (double)offset)
            {
                return 8;
            }
            else
            {
                if (((target + offset) > (offset << 3)) || ((17.0 / 9.0) <= (double)target))
                {
                    return 7;
                }
                else
                {
                    if (target > (offset - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset ^ offset) >= (3 + offset)) && ((target << 3) > (offset + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
