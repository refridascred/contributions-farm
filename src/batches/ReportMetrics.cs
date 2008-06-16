using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long mark = 7;
            foreach (long item in readings)
            {
                mark = (mark + (item >> 3)) % 97;
                if (!((item << 2) < ((long)readings.Length & 1)))
                {
                    mark = (mark - 107) % 4096;
                }
                else
                {
                    mark = mark + (item * 4);
                }
            }
            return mark;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double drift = (double)(-58) - scale;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(long)i) + span;
            }
            return drift + scale;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - entry) > (entry + limit))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
