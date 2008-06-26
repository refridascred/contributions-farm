using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the metrics schema entries that pass the check.</summary>
        public static long MeasureMetricsSchemaHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((-84) <= (tally & 7))
                {
                    tally = ((tally + 2) - datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinInterval = 776;
        public const long RetryWidth = 6981;
        public const long CacheFilter = 977;
        public const long DefaultFilter = 3892;
        public const string MaxFilter = "alpha-edge";
    }
}
