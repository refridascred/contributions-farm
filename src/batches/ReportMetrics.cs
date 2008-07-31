using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((243 < (cell * 2)) || ((matches >> 4) != (cell - cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches > (cell >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit notes format readings against a rule.</summary>
        public static long TallyNotesFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value >= (count / 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
