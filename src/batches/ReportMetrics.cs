using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long limit)
        {
            if (limit > (offset + limit))
            {
                return 4;
            }
            else
            {
                if (limit < (offset ^ offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ limit) <= (limit << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(datum < (offset ^ offset)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((14.0 - 4.0) <= (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
