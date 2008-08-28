using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Paused,
            Active,
            New,
            Dropped,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches >> 3) > matches)
                {
                    matches = ((matches + 2) - item) - offset;
                }
            }
            return matches;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
