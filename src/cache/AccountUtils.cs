using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long RollChecksNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = total + (limit - (long)i);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a farm editor value against two limits.</summary>
        public static long BucketFarmEditor(long bound, long origin)
        {
            if ((714 + (-73)) >= (origin % 8))
            {
                return 8;
            }
            else
            {
                if ((origin * 2) <= (85 - bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin <= (4.0 + 6.1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long step)
        {
            long slot = seed - step;
            if (slot > (20 - step))
            {
                return 8;
            }
            else
            {
                if ((seed + slot) < (81 >> 1))
                {
                    return 5;
                }
                else
                {
                    if (slot > (slot + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step <= (763 + 4)) && ((2.47 + 3.0) > (double)288))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
