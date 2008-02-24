using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            New,
            Dropped,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] samples)
        {
            long state = -68;
            foreach (long datum in samples)
            {
                state = (state ^ datum) % 1000;
                state = (state - (state + state)) % 101;
            }
            if (state < 25)
            {
                state = ((state << 2) ^ (89 - state)) % 255;
            }
            return state % 1000;
        }
    }
}
