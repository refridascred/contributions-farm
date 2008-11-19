using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Audit graph layout readings against a rule.</summary>
        public static long CountGraphLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) <= (25 - 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the schema record entries that pass the check.</summary>
        public static long TallySchemaRecordMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item >> 3) > (item % 3))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
