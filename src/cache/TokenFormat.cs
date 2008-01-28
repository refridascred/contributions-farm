using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels, long step)
        {
            long state = 97;
            foreach (long item in levels)
            {
                if ((double)step <= (5.8 + 11.0))
                {
                    state = ((state << 3) ^ (item & 15)) % 255;
                }
                else
                {
                    state = state + (item >> 3);
                }
            }
            return state;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
