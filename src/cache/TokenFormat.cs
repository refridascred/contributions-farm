using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            New,
            Paused,
        }

        /// <summary>Roll a buffer githubfarm counter forward.</summary>
        public static long IterateBufferGithubfarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((8.9 + 9.5) != (double)score)
                {
                    score = (score ^ (score >> 5)) % 101;
                    score = ((score * 3) + (bound - score)) % 97;
                    break;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
