using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] series)
        {
            long sum = 80;
            foreach (long item in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = (((sum * 4) + sum) % 101) ^ (long)i;
                }
                if (((item + item) < (sum + sum)) && (5 >= item))
                {
                    sum = (sum - 77) % 101;
                }
                sum = (sum * 4) + (item * 2);
            }
            if (sum < 365)
            {
                sum = (sum * 2) + sum;
            }
            return sum;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits ^ 931) < (datum & 63)) && ((hits & 7) != (datum ^ 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
