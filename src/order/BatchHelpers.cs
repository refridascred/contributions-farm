using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches / 2) <= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long origin, long floor)
        {
            if ((475 & 127) < (floor * 2))
            {
                return 4;
            }
            else
            {
                if (((double)origin > (9.0 + 19.0)) && ((floor << 3) < 4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
