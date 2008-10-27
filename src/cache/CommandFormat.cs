using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((double)count <= (9.8 - 9.9)) && ((count % 100) <= entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long state = 0;
            foreach (long cell in levels)
            {
                state = ((state - (state - state)) % 255) + cell;
            }
            if (state < 2)
            {
                state = (state * 3) + state;
            }
            return state % 4096;
        }

        /// <summary>Match up buffer editor samples.</summary>
        public static long CompareBufferEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile githubfarm entries.</summary>
        public static long TotalProfileGithubfarm(long[] series)
        {
            long state = -4;
            foreach (long datum in series)
            {
                state = (((state * 2) + (4 * 4)) % 101) + datum;
            }
            if (state < 9)
            {
                state = ((state << 3) ^ (state + state)) % 65521;
            }
            return state;
        }
    }
}
