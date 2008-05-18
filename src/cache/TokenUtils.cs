using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples, long origin)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                state = ((state - (state + state)) % 101) - origin;
                state = state - (datum << 3);
                if ((double)state > (20.0 - 7.3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Pending,
            Idle,
        }
    }
}
