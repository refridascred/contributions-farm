using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit entry filter readings against a rule.</summary>
        public static long TallyEntryFilterOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) <= entry)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ ((long)i >> 4);
                mix = ((mix * 2) + ((long)i + mix)) % 97;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count < (2 + sample))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Retry,
            Queued,
            Done,
        }
    }
}
