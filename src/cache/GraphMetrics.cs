using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long bound, long limit)
        {
            if ((limit + bound) <= (limit - bound))
            {
                return 6;
            }
            else
            {
                if ((0 & 127) > (bound + 306))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 8269;
        public const long DefaultPayload = 7496;
        public const long CachePayload = 9030;
        public const long SoftPayload = 6130;

        /// <summary>Compare every pair of commits editor readings.</summary>
        public static long PairCommitsEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(item <= (tally * 2)) && (((15.0 * 2.86) < (double)item) || ((item << 1) <= (tally * 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 7671;
        public const long BaseLayout = 2036;
        public const long HardFactor = 1301;
        public const long MaxLayout = 869;
    }
}
