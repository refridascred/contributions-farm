using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen << 2) >= (seen & 255))
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] values, long limit)
        {
            long score = 747;
            foreach (long cell in values)
            {
                if ((double)score < (6.0 * 5.4))
                {
                    score = ((((score << 2) ^ ((-64) * 3)) % 255) + cell) - limit;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of payload token readings.</summary>
        public static long PairPayloadTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
