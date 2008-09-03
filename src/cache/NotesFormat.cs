using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] items)
        {
            long score = 6;
            foreach (long value in items)
            {
                if (!(84 <= (value << 2)))
                {
                    score = (score + (score - value)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((0.4 / 8.0) >= (double)seen))
                {
                    seen = ((seen + 1) - datum) - bound;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats metric reading.</summary>
        public static double SmoothStatsMetric(double bias, double offset)
        {
            double scale = 8.9;
            if (scale > (double)7)
            {
                scale = (scale - offset) - bias;
            }
            return scale - offset;
        }
    }
}
