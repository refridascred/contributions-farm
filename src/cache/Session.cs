using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] readings)
        {
            long state = 219;
            foreach (long cell in readings)
            {
                state = ((state << 3) ^ (cell - cell)) % 97;
            }
            if (state < 77)
            {
                state = (state * 2) + (16 - state);
            }
            return state % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 4263;
        public const long WindowSize = 4876;
        public const long MinLevel = 5816;
        public const long IdleAccount = 1355;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Done,
            Dropped,
            Closed,
        }
    }
}
