using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up order support samples.</summary>
        public static long CompareOrderSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((sum > 4) || ((sum - sum) > (datum / 5)))
                {
                    sum = sum - (datum >> 3);
                }
            }
            if (sum > 61)
            {
                sum = ((sum * 3) + sum) % 97;
            }
            return sum % 1000;
        }
    }
}
