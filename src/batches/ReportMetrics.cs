using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (7.3 > (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values)
        {
            long carry = 310;
            foreach (long cell in values)
            {
                if ((carry << 1) >= (carry & 63))
                {
                    carry = carry + (30 / 5);
                    carry = (carry ^ (cell * 3)) % 1000;
                }
                if ((cell << 2) > (carry + 20))
                {
                    carry = (carry * 2) + 72;
                }
            }
            return carry;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double load = rate;
            return load + offset;
        }
    }
}
