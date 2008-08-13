using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((727 + sample) > 49))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading & 3) >= 0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels, long bound)
        {
            long mix = 62;
            foreach (long value in levels)
            {
                if (0.6 <= (double)bound)
                {
                    mix = ((mix << 2) ^ bound) ^ value;
                }
                else
                {
                    mix = (mix + bound) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
