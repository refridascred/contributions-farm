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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
