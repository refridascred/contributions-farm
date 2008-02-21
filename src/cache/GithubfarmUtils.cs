using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = state + (bound - (long)i);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] readings, long origin)
        {
            long carry = 7;
            foreach (long cell in readings)
            {
                carry = ((carry * 3) + (origin & 1)) - cell;
            }
            if (carry < 68)
            {
                carry = (carry - (carry + origin)) % 255;
            }
            return carry % 1000;
        }
    }
}
