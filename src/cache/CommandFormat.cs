using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series, long step)
        {
            long anchor = 11;
            foreach (long sample in series)
            {
                if ((anchor & 63) >= (sample >> 2))
                {
                    anchor = ((anchor + (100 * 5)) % 101) + step;
                }
            }
            return anchor % 97;
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
