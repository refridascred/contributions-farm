using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((5.0 / 6.0) <= (double)hits)
                {
                    hits = ((hits + 3) ^ entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue githubfarm counter forward.</summary>
        public static long IterateQueueGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc << 3) ^ step) % 255;
                acc = ((acc << 2) ^ (step % 10)) % 1000;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + hits) == ((long)readings.Length ^ cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
