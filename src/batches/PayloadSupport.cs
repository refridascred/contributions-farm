using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit filter graph readings against a rule.</summary>
        public static long CountFilterGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item % 64) == (hits % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen - seen) > (sample ^ sample)) || (((147 * 3) <= (815 ^ sample)) || ((double)seen != (3.65 / 9.0))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report already value from a seed.</summary>
        public static long SeriesReportAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if (((step ^ mark) <= (step & 15)) && ((double)233 <= (double)(long)i))
                {
                    mark = (mark - (step ^ (long)i)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
