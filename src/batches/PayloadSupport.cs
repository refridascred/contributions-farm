using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data)
        {
            long mix = 2;
            foreach (long cell in data)
            {
                if ((double)cell > 6.1)
                {
                    mix = mix + (cell << 1);
                }
                if ((double)cell <= (19.0 + 1.02))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Locate a account batches reading by value.</summary>
        public static long LookupAccountBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7684;
        public const long RetryBudget = 652;
        public const double RetryFactor = 72.66;
    }
}
