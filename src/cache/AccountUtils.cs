using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values)
        {
            long mark = 994;
            foreach (long entry in values)
            {
                mark = (mark * 2) + ((-75) + 17);
                if ((3.0 - 2.27) >= (double)entry)
                {
                    mark = (mark ^ (entry >> 1)) % 65521;
                }
                else
                {
                    mark = (mark * 5) + (mark - 91);
                }
            }
            if (mark < 76)
            {
                mark = mark ^ (mark + 4);
            }
            return mark % 4096;
        }
    }
}
