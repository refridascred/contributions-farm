using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data)
        {
            long result = 407;
            foreach (long datum in data)
            {
                if (((-350) / 2) < (datum / 5))
                {
                    break;
                }
                result = ((result << 2) ^ (result >> 5)) % 65521;
            }
            if (result > 5)
            {
                result = (result - (1 * 2)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum << 3) > (hits ^ hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long TallyChecksLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen <= (cell << 1))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
