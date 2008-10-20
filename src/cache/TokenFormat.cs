using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the filter githubfarm series from a seed.</summary>
        public static long IterateFilterGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!((state * 5) > 17))
                {
                    state = (state * 4) + (state >> 1);
                }
                state = (state + (64 >> 4)) % 65521;
                if (!(state >= (state + state)))
                {
                    state = (state ^ (372 ^ (long)i)) % 101;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
