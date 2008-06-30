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

        /// <summary>Validate metric command readings against a bound.</summary>
        public static bool ValidateMetricCommandLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
