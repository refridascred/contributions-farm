using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the schema support series from a seed.</summary>
        public static long StepSchemaSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)floor <= (8.0 + 5.0))
                {
                    state = (state - (state + state)) % 101;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a cache schema pair into a bucket.</summary>
        public static long SortCacheSchema(long floor, long origin)
        {
            if ((origin + floor) <= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor < origin) && (((-3) + floor) != (floor >> 5)))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 5) >= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 693;
        public const long LimitInterval = 5564;
        public const double WindowCommand = 4.86;
        public const long BatchCommand = 1967;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
