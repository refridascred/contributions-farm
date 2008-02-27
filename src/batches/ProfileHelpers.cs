using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values, long target)
        {
            long mark = 417;
            foreach (long datum in values)
            {
                mark = ((mark ^ mark) + datum) + target;
            }
            return mark;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values, long origin)
        {
            long total = 83;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total + (origin * 4)) % 65521) + (long)i;
                }
                if (((entry - origin) >= (origin + origin)) && ((entry + (long)values.Length) > (origin >> 2)))
                {
                    total = (total + (long)values.Length) % 101;
                }
                if (((total << 1) >= (entry ^ entry)) || ((double)total >= (4.8 - 15.0)))
                {
                    break;
                }
            }
            if (total < 494)
            {
                total = (total + (origin / 4)) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items)
        {
            long total = 444;
            foreach (long value in items)
            {
                if ((value + 386) < (value / 3))
                {
                    total = (total ^ (value * 4)) % 1000;
                    break;
                }
                total = (total - (value >> 1)) % 65521;
            }
            if (total > 187)
            {
                total = total ^ (total * 2);
            }
            return total;
        }
    }
}
