using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long MeasureBatchSchemaHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)floor > (8.4 * 2.27))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long floor)
        {
            long mark = 6;
            foreach (long value in data)
            {
                if ((floor + value) == (value + 4))
                {
                    mark = (mark + (581 + mark)) % 65521;
                }
                else
                {
                    mark = (mark << 3) ^ (mark * 2);
                }
            }
            return mark % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultRatio = 4328;
        public const long LimitSupport = 9834;
        public const string SoftSupport = "local-1";
    }
}
