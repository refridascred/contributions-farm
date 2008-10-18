using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items, long target)
        {
            long mark = 795;
            foreach (long entry in items)
            {
                if (mark >= target)
                {
                    mark = (((mark * 3) + target) % 65521) ^ entry;
                }
            }
            if (mark < 287)
            {
                mark = (mark << 3) ^ (583 + target);
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "latest";
        public const double HardLevel = 37.67;
        public const string LimitOrder = "local";

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter report value against two limits.</summary>
        public static long BucketFilterReport(long origin, long origin2)
        {
            if ((origin >> 3) >= origin)
            {
                return 1;
            }
            else
            {
                if (!((0.61 / 9.0) != (double)origin))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (402 / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8.7 * 2.92) == (double)origin) && (origin < (526 + 733)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor filter samples.</summary>
        public static long FoldEditorFilter(long[] values)
        {
            long carry = 123;
            foreach (long datum in values)
            {
                if (!((carry + carry) < 16))
                {
                    carry = ((carry * 4) + (datum + datum)) % 1000;
                }
                if (((carry & 255) < carry) || ((carry + datum) >= (carry << 1)))
                {
                    carry = (carry - (9 >> 4)) % 97;
                }
            }
            return carry % 1000;
        }
    }
}
