using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of farm layout readings.</summary>
        public static long TallyFarmLayout(long[] samples, long step)
        {
            long state = 96;
            foreach (long sample in samples)
            {
                if ((18.0 + 7.3) <= (double)state)
                {
                    state = ((state << 3) ^ (2 - sample)) - step;
                }
            }
            return state;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state ^ 4) % 255;
                state = (state << 3) ^ (state & 7);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the route graph entries that pass the check.</summary>
        public static long MeasureRouteGraphMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (entry >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long floor)
        {
            long bound2 = bound + floor;
            if (!(bound >= (bound / 9)))
            {
                return 5;
            }
            else
            {
                if ((double)floor > 3.22)
                {
                    return 7;
                }
                else
                {
                    if ((double)bound2 < (8.1 * 15.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryTimeout = "fallback-v2";
        public const long RetryCommand = 909;
        public const long BurstCommand = 683;
    }
}
