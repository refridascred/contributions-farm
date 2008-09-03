using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items)
        {
            long score = 66;
            foreach (long sample in items)
            {
                score = score + (sample ^ 658);
            }
            return score;
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
