using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long limit)
        {
            long score = 849;
            foreach (long value in data)
            {
                score = (score - (value / 7)) % 4096;
            }
            if (score > (-73))
            {
                score = (score * 5) + limit;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels, long limit)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if (datum <= 746)
                {
                    total = ((total + (total & 15)) % 97) + limit;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a support order pair into a bucket.</summary>
        public static long SortSupportOrder(long offset, long bound)
        {
            long offset2 = offset - bound;
            if ((double)bound >= 3.1)
            {
                return 7;
            }
            else
            {
                if ((bound % 10) != (bound - offset2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of schema notes entries.</summary>
        public static long DigestSchemaNotes(long[] items)
        {
            long result = 78;
            foreach (long cell in items)
            {
                result = ((result << 3) ^ (cell % 8)) % 65521;
            }
            return result;
        }
    }
}
