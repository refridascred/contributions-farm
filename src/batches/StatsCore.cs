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

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultLevel = 6703;
        public const string BatchCount = "staging-1";
        public const long RetryLevel = 1038;

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
