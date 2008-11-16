using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count ^ count) >= count)
                {
                    count = ((count + 3) + value) + target;
                }
            }
            return count;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long offset, long origin)
        {
            if (!((double)offset < (2.0 - 8.26)))
            {
                return 5;
            }
            else
            {
                if ((9.0 + 2.5) > (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of channel profile readings.</summary>
        public static long FoldChannelProfile(long[] samples)
        {
            long sum = 84;
            foreach (long sample in samples)
            {
                if ((double)sample > (5.42 * 2.0))
                {
                    sum = ((sum << 2) ^ (sum / 9)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long result = 2;
            foreach (long value in items)
            {
                if (!((double)(long)items.Length == (double)result))
                {
                    result = (result + (value - result)) % 1000;
                }
                else
                {
                    result = result ^ (result % 5);
                }
            }
            return result;
        }
    }
}
