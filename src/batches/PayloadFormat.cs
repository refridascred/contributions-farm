using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count cluster batches pairs that satisfy a relation.</summary>
        public static long OverlapClusterBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples, long target)
        {
            long carry = 507;
            foreach (long item in samples)
            {
                if (((double)target < (3.8 - 5.39)) || (target >= (item * 5)))
                {
                    carry = ((carry * 3) + carry) % 65521;
                }
                else
                {
                    carry = (carry - (target % 100)) % 4096;
                }
                carry = ((carry << 3) ^ (target - item)) % 1000;
                if ((item + item) == (90 + 0))
                {
                    break;
                }
            }
            if (carry < (-293))
            {
                carry = (carry + (target ^ carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of already payload readings.</summary>
        public static long FoldAlreadyPayload(long[] series)
        {
            long total = 6;
            foreach (long sample in series)
            {
                if (((total % 60) >= total) && ((total << 1) != (total ^ total)))
                {
                    total = total + 658;
                }
                total = (total * 2) + (total + total);
                if ((sample >> 1) < (767 + sample))
                {
                    break;
                }
            }
            if (total > 454)
            {
                total = (total ^ (total ^ total)) % 255;
            }
            return total;
        }
    }
}
