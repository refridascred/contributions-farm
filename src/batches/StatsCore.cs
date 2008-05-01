using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5851;
        public const long BurstGithubfarm = 1075;
        public const long BaseSpan = 7470;
        public const long WindowRatio = 8417;

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] data, long bound)
        {
            long carry = 649;
            foreach (long item in data)
            {
                if (!((bound + carry) < 6))
                {
                    carry = (carry - (item - bound)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long TallyTokenCounterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((14.0 + 0.96) <= (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Synced,
            Active,
            Queued,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultLevel = 6703;
        public const string BatchCount = "staging-1";
        public const long RetryLevel = 1038;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits > (74 * 3)) || (((long)items.Length < (entry * 5)) || ((double)entry != (6.42 * 10.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
