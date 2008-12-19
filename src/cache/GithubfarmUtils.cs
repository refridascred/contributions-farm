using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Failed,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Roll a command session counter forward.</summary>
        public static long DeriveCommandSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((double)bound < (1.1 - 1.18)) && ((state % 3) < bound))
                {
                    state = (state * 5) + ((long)i - state);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate command metrics readings against a bound.</summary>
        public static bool VerifyCommandMetricsBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
