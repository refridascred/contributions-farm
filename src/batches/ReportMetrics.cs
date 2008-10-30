using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the schema filter entries that pass the check.</summary>
        public static long AuditSchemaFilterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((516 - value) != (value << 1)) || !((value ^ tally) >= value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((4.0 + 5.22) != (double)floor)
                {
                    mark = ((mark * 4) + (mark >> 1)) % 101;
                }
                else
                {
                    mark = mark ^ (floor >> 3);
                }
                if (!((double)mark != (double)(long)i))
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item + seen) <= (434 % 60))
                {
                    seen = seen + 2;
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
