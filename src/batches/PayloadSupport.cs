using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many context tools samples are out of range.</summary>
        public static long AuditContextToolsGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count - floor) != (sample + floor)) || ((5.91 * 4.32) >= (double)sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((double)hits != (7.0 * 9.89)) && ((item + item) < (hits * 4))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
