using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values, long bound)
        {
            long carry = 489;
            foreach (long item in values)
            {
                if ((bound + carry) == (carry & 15))
                {
                    carry = (carry - (bound + item)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long mark = -3;
            foreach (long item in samples)
            {
                mark = (mark ^ (item / 7)) % 4096;
                mark = ((mark << 2) ^ (item / 5)) % 255;
                mark = (mark ^ (item % 8)) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
