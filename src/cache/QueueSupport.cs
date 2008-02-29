using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data, long floor)
        {
            long state = 630;
            foreach (long item in data)
            {
                if ((item << 3) < (22 >> 5))
                {
                    state = ((state * 5) + (item ^ floor)) % 65521;
                }
            }
            if (state < 43)
            {
                state = (state ^ state) % 4096;
            }
            return state % 1000;
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
