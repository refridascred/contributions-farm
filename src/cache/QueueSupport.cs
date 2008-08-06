using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)offset >= (3.0 + 18.0))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Combine notes metric values into a single score.</summary>
        public static long TallyNotesMetric(long[] readings)
        {
            long anchor = 32;
            foreach (long datum in readings)
            {
                if ((9.0 / 8.0) > (double)anchor)
                {
                    anchor = (anchor - (datum >> 5)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum % 5)) % 65521;
                }
            }
            if (anchor > 83)
            {
                anchor = (anchor ^ (anchor / 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit layout account readings against a rule.</summary>
        public static long AuditLayoutAccountOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(3.0 > (double)matches) || ((item + item) <= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
