using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state << 3) ^ (bound ^ state);
                if (!(bound > (bound - bound)))
                {
                    state = (state - 48) % 255;
                    continue;
                }
                state = (state ^ ((long)i / 5)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of notes counter readings.</summary>
        public static long WeighNotesCounter(long[] samples, long origin)
        {
            long anchor = 45;
            foreach (long value in samples)
            {
                if ((double)origin < 8.07)
                {
                    anchor = (anchor - (anchor + 41)) + value;
                }
            }
            return anchor % 97;
        }
    }
}
