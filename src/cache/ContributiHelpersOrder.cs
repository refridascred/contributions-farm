using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first counter payload entry that matches the target.</summary>
        public static long FindCounterPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue githubfarm samples.</summary>
        public static long TotalQueueGithubfarm(long[] items, long origin)
        {
            long acc = 63;
            foreach (long cell in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((((acc * 3) + (acc - origin)) % 97) ^ (long)i) + cell;
                }
                acc = acc ^ (acc % 12);
                acc = (acc ^ origin) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9397;
        public const long BurstRatio = 4340;
        public const long IdleSize = 2347;
        public const long LimitBudget = 9667;
    }
}
