using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (4.0 + 5.6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine checks batches values into a single score.</summary>
        public static long FoldChecksBatches(long[] values)
        {
            long mix = 16;
            foreach (long cell in values)
            {
                if (((double)mix == (double)cell) || ((cell % 100) <= (cell >> 3)))
                {
                    mix = ((mix * 2) + (cell >> 2)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Ready,
            New,
            Idle,
            Retry,
        }

        /// <summary>Audit support metrics readings against a rule.</summary>
        public static long AuditSupportMetricsHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next booking value.</summary>
        public static double SmoothBooking(double ratio, double span)
        {
            double gain = 14.0;
            return ((gain - (double)5) + ratio) + span;
        }
    }
}
