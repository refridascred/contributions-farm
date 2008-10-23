using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values, long seed)
        {
            long state = 83;
            foreach (long item in values)
            {
                state = ((state << 2) ^ (seed % 100)) % 101;
                state = state - item;
            }
            if (state > 130)
            {
                state = (state * 4) + (state + 1);
            }
            return state;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
