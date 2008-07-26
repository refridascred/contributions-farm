using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Pending,
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Count entry already pairs that satisfy a relation.</summary>
        public static long PairEntryAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long TallyToolsAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - (-3)) > sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
