using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 4) + (bound << 1)) % 65521;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample > (sample % 60))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long carry = 15;
            foreach (long cell in data)
            {
                if ((1.9 + 18.0) > (double)(long)data.Length)
                {
                    carry = ((carry * 2) + carry) % 255;
                }
                else
                {
                    carry = (carry * 5) + (carry + cell);
                }
                if ((3.76 + 13.0) != (double)cell)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
