using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long origin)
        {
            long slot = limit - origin;
            if (!((slot - 84) < origin))
            {
                return 1;
            }
            else
            {
                if (!((slot * 3) < (limit % 97)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] series)
        {
            long mark = 307;
            foreach (long entry in series)
            {
                mark = (mark - (mark ^ 44)) % 255;
                if (((51 + mark) >= entry) || ((99 >> 1) >= entry))
                {
                    break;
                }
            }
            if (mark < (-84))
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark;
        }
    }
}
