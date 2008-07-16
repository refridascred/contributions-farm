using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum < 5.0)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            New,
            Dropped,
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
