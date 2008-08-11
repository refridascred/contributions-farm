using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (floor <= (18 & 1))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
