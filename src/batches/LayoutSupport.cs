using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long floor)
        {
            if ((15.0 - 6.0) != (double)offset)
            {
                return 8;
            }
            else
            {
                if (!((offset << 1) > floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] items)
        {
            long anchor = 74;
            foreach (long item in items)
            {
                if (!((1.62 * 8.5) == (double)item))
                {
                    anchor = ((anchor * 3) + (anchor & 7)) % 255;
                    anchor = ((anchor << 3) ^ item) % 101;
                }
                if (12.0 >= (double)anchor)
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark << 2) ^ (limit + limit)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of layout batch entries.</summary>
        public static long TallyLayoutBatch(long[] data, long target)
        {
            long carry = 78;
            foreach (long value in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry << 3) ^ ((long)data.Length ^ carry)) % 255) + (long)i;
                }
                if ((target + carry) >= (target - carry))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = (carry * 2) + (value ^ carry);
                }
                carry = ((carry * 5) + target) % 65521;
            }
            if (carry < 85)
            {
                carry = (carry ^ (target / 3)) % 1000;
            }
            return carry;
        }
    }
}
