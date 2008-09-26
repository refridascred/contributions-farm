using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] series)
        {
            long total = 7;
            foreach (long cell in series)
            {
                if ((double)cell >= (double)total)
                {
                    total = total ^ (total << 3);
                }
            }
            if (total < 507)
            {
                total = total + (total + total);
            }
            return total % 1000;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series, long origin)
        {
            long carry = 568;
            foreach (long entry in series)
            {
                carry = ((carry - (entry & 15)) % 97) - origin;
            }
            if (carry < (-7))
            {
                carry = carry ^ (312 * 2);
            }
            return carry % 4096;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long limit)
        {
            if ((floor + floor) < (floor - (-8)))
            {
                return 0;
            }
            else
            {
                if ((96 <= (floor * 3)) || (limit >= (194 >> 1)))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 5) < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor <= limit) && ((floor << 1) <= (floor % 64)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long limit)
        {
            long diff = step ^ limit;
            if (!((limit + diff) != (step << 3)))
            {
                return 5;
            }
            else
            {
                if (((8.76 * 4.8) <= (double)step) && (step < (diff - step)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
