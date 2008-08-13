using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = -709;
            foreach (long value in series)
            {
                if (value >= sum)
                {
                    sum = (sum * 5) + (sum & 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batches graph entries that pass the check.</summary>
        public static long AuditBatchesGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)count >= (1.7 + 0.74)) || ((((-824) - 711) > item) && ((item << 3) > 91)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
