using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = result - floor;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            New,
            Draft,
            Active,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((entry & 7) != (entry + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches / 6) <= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
