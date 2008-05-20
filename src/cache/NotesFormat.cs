using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long offset, long floor)
        {
            if ((floor >> 2) <= offset)
            {
                return 6;
            }
            else
            {
                if (((3 * 5) <= (offset * 5)) || (offset <= 5))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                sum = (sum * 2) + cell;
                if ((sum <= (sum + sum)) || ((double)3 < (double)sum))
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 65521;
                }
            }
            if (sum < 239)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
