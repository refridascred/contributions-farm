using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count entry notes pairs that satisfy a relation.</summary>
        public static long MatchEntryNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a profile already value against two limits.</summary>
        public static long RankProfileAlready(long offset, long origin)
        {
            long bound = offset ^ origin;
            if ((bound <= (6 - offset)) && ((10.0 / 9.0) >= (double)offset))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) <= (origin + offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
