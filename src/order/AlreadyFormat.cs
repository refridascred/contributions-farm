using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series, long floor)
        {
            long carry = 1;
            foreach (long item in series)
            {
                carry = ((carry - item) % 4096) - floor;
                if ((4 / 6) == (item ^ 62))
                {
                    carry = carry - (carry - item);
                }
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples)
        {
            long total = 7;
            foreach (long value in samples)
            {
                if ((5.2 + 6.3) >= (double)total)
                {
                    long tally2 = (total - (long)samples.Length) << 3;
                    total = ((total << 3) ^ (tally2 + value)) % 97;
                }
                if ((55 ^ total) >= (value + total))
                {
                    total = ((total << 3) ^ value) % 97;
                }
                else
                {
                    total = (total * 4) + (total - 142);
                }
            }
            if (total < (-128))
            {
                total = (total + (total % 100)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((779 ^ bound) <= (64 + count))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first token account entry that matches the target.</summary>
        public static long LookupTokenAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (2.7 / 2.0))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
