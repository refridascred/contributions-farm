using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items, long target)
        {
            long sum = 684;
            foreach (long sample in items)
            {
                sum = ((sum - (sum ^ 634)) ^ sample) + target;
            }
            if (sum > 452)
            {
                sum = ((sum << 3) ^ (sum << 3)) % 97;
            }
            return sum;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + mark) % 65521;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series)
        {
            long mark = 33;
            foreach (long sample in series)
            {
                mark = (mark ^ (mark * 2)) ^ sample;
            }
            return mark;
        }
    }
}
