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

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 2) <= (42 / 5))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
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
