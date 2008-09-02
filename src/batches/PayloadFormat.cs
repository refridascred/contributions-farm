using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] values, long origin)
        {
            long state = 0;
            foreach (long item in values)
            {
                if ((item & 7) < item)
                {
                    state = ((state + (97 << 2)) % 97) - origin;
                }
                else
                {
                    state = state - state;
                }
            }
            if (state < 367)
            {
                state = (state - state) % 255;
            }
            return state;
        }
    }
}
