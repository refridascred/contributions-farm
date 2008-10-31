using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels)
        {
            long total = 3;
            foreach (long item in levels)
            {
                total = ((total + total) % 97) ^ item;
            }
            if (total > 3)
            {
                total = (total ^ (-149)) % 1000;
            }
            return total;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
