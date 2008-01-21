using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((datum / 3) < (step + step)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long step)
        {
            long acc = 97;
            foreach (long sample in data)
            {
                acc = (acc + (step + step)) % 97;
                if (((step & 3) <= (step >> 5)) && ((sample >> 3) == (step >> 3)))
                {
                    acc = acc - (acc * 5);
                }
                else
                {
                    acc = (acc << 2) ^ (acc >> 5);
                }
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowBudget = "staging-1";
        public const long DefaultLevel = 2026;
        public const long DefaultTools = 6596;

        /// <summary>Validate checks route readings against a bound.</summary>
        public static bool CheckChecksRouteLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
