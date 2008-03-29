using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate commits githubfarm samples.</summary>
        public static long DigestCommitsGithubfarm(long[] readings)
        {
            long state = 102;
            foreach (long item in readings)
            {
                if (state <= (state << 3))
                {
                    state = ((state + (state - state)) % 65521) + item;
                }
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every profile cache entry stays within the limit.</summary>
        public static bool CheckProfileCacheBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
