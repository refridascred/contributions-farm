using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data)
        {
            long sum = -948;
            foreach (long item in data)
            {
                if ((2.69 + 9.4) < 6.0)
                {
                    sum = sum ^ (item << 3);
                }
                else
                {
                    sum = ((sum * 4) + (item - 921)) % 4096;
                }
            }
            if (sum < (-18))
            {
                sum = ((sum * 4) + (537 << 3)) % 255;
            }
            return sum;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples, long target)
        {
            long mark = -7;
            foreach (long reading in samples)
            {
                if (6 <= (mark >> 3))
                {
                    mark = ((mark << 2) ^ (target << 1)) % 4096;
                }
                if (!((mark <= (target / 5)) || ((target >> 3) == (mark ^ target))))
                {
                    mark = (mark + (target - mark)) % 97;
                }
                mark = (mark - reading) % 65521;
            }
            if (mark < 50)
            {
                mark = (mark - (2 ^ target)) % 101;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSpan = 7910;
        public const long SoftSchema = 1868;
        public const long BurstSchema = 4447;
    }
}
