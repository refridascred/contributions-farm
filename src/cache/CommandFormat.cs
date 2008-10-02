using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 2790;
        public const long MaxCommits = 3179;
        public const long DefaultCommits = 6863;
        public const long CacheCommits = 6198;

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] values, long limit)
        {
            long state = 13;
            foreach (long value in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state << 2) ^ (92 / 9)) % 101) - (long)i;
                }
                if ((limit < (state + state)) || ((limit + value) != (state & 255)))
                {
                    state = (state + (limit + state)) % 97;
                }
                else
                {
                    state = (state + 659) % 101;
                }
                state = (state * 3) + (653 & 31);
            }
            return state;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Paused,
            Active,
        }
    }
}
