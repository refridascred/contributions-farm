using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                long matches = (total + total) >> 3;
                if ((matches ^ (long)i) != (total - total))
                {
                    total = ((total << 2) ^ (total % 24)) % 255;
                }
                if ((double)matches <= (9.8 + 6.77))
                {
                    total = (total - (total - matches)) % 101;
                }
                else
                {
                    total = ((total * 5) + matches) % 65521;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the channel schema entries that pass the check.</summary>
        public static long AuditChannelSchemaMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((item - 494) >= (hits & 15)) || ((hits & 63) < (3 + item))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
