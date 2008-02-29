using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate token stream samples.</summary>
        public static long DigestTokenStream(long[] series)
        {
            long mark = 73;
            foreach (long datum in series)
            {
                mark = (((mark * 5) + (mark - 1)) % 4096) ^ datum;
            }
            if (mark < 88)
            {
                mark = (mark + (mark & 15)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long CountChecksSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((42 ^ seen) == (seen << 1))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Audit record report readings against a rule.</summary>
        public static long AuditRecordReportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - entry) != (entry / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
