using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Stale,
            Queued,
            Pending,
            Locked,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((3.1 + 5.4) > (double)origin)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
