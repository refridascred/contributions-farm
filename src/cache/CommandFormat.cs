using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples, long offset)
        {
            long anchor = 562;
            foreach (long item in samples)
            {
                anchor = (((anchor * 3) + offset) % 255) ^ item;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Locked,
            Paused,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((state + bound) == ((long)i / 7))
                {
                    state = (state + ((long)i >> 3)) % 4096;
                    continue;
                }
                else
                {
                    state = (state * 2) + (bound >> 3);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
