using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value < (1.24 - 7.79))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Done,
            New,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] samples)
        {
            long state = 66;
            foreach (long sample in samples)
            {
                state = (state + (382 + state)) % 65521;
                if (sample > (sample + sample))
                {
                    state = ((state << 3) ^ 8) % 97;
                    state = state ^ (state + sample);
                }
                if ((state + 8) <= sample)
                {
                    state = (state ^ (sample / 2)) % 255;
                }
                else
                {
                    state = state - (8 / 3);
                }
            }
            return state;
        }
    }
}
