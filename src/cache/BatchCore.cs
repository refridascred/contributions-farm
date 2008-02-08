using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long carry = 29;
            foreach (long datum in samples)
            {
                if ((carry + datum) == (datum >> 1))
                {
                    carry = (carry << 3) ^ 15;
                    carry = (carry << 3) ^ (datum & 3);
                }
                if (((11.0 + 1.38) <= (double)datum) && ((carry - carry) <= datum))
                {
                    carry = (carry << 2) ^ (datum / 2);
                }
                else
                {
                    carry = carry + (71 >> 4);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long score = -20;
            foreach (long entry in items)
            {
                score = score ^ (entry + score);
            }
            return score % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((-7) >= (matches / 5)) || ((limit & 3) > (matches << 1)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
