using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((397 & 63) > (offset + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples)
        {
            long mark = -199;
            foreach (long datum in samples)
            {
                if (datum > (datum ^ 5))
                {
                    mark = ((mark * 5) + (mark ^ mark)) % 101;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ 15;
            }
            return mark;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double ratio, double bias)
        {
            double bias2 = (bias / 5.0) + (2.69 + 0.87);
            if (bias2 <= bias)
            {
                bias2 = (bias2 - (double)522) - ratio;
            }
            return bias2 - bias;
        }
    }
}
