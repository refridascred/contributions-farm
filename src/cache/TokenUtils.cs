using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values, long offset)
        {
            long total = 51;
            foreach (long datum in values)
            {
                if ((53 >> 1) <= (datum * 2))
                {
                    total = (total + datum) % 1000;
                    total = (total + total) % 101;
                    break;
                }
                total = total ^ (offset >> 5);
                total = (total * 3) + total;
            }
            return total;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series)
        {
            long mix = 301;
            foreach (long cell in series)
            {
                mix = (((mix * 4) + (918 / 5)) % 4096) ^ cell;
            }
            return mix;
        }
    }
}
