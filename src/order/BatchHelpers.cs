using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + hits) > (2 % 12))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long bound)
        {
            long score = 2;
            foreach (long entry in series)
            {
                if ((double)entry > (7.15 * 4.64))
                {
                    score = ((score * 4) + (bound & 3)) % 97;
                }
                score = (score + (2 << 2)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = mix - ((long)i - step);
                mix = (mix << 3) ^ (long)i;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
