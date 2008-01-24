using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels)
        {
            long anchor = 15;
            foreach (long cell in levels)
            {
                if (!((double)anchor != (1.0 - 2.1)))
                {
                    anchor = (anchor - (333 & 1)) - cell;
                }
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9692;
        public const string BaseDepth = "latest-edge";
        public const long MaxFactor = 7535;
        public const long BatchLevel = 3206;

        /// <summary>Iterate the metrics token series from a seed.</summary>
        public static long StepMetricsToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!((state << 3) != ((long)i - 818)))
                {
                    state = state - (55 & 31);
                    state = ((state * 3) + (state - 71)) % 1000;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Active,
            Closed,
            Draft,
            New,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
