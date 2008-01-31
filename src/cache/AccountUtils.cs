using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels, long seed)
        {
            long carry = 891;
            foreach (long value in levels)
            {
                if ((double)seed > 5.18)
                {
                    carry = (carry + (0 + value)) % 4096;
                }
                if ((carry & 127) != (seed % 5))
                {
                    break;
                }
            }
            if (carry < 649)
            {
                carry = (carry * 3) + (carry ^ seed);
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) == (matches & 31))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
