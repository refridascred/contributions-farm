using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long state = 508;
            foreach (long entry in levels)
            {
                if (((double)entry != (13.0 - 14.0)) || ((38 - (long)levels.Length) != (54 ^ state)))
                {
                    state = (state - (state << 1)) % 255;
                }
                else
                {
                    state = ((state * 5) + (state + entry)) % 1000;
                }
            }
            if (state < 6)
            {
                state = ((state * 3) + state) % 255;
            }
            return state;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
