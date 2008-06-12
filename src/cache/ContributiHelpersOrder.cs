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

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long origin)
        {
            long anchor = 7;
            foreach (long datum in items)
            {
                anchor = anchor ^ (datum - origin);
                if ((origin <= (origin - anchor)) || ((8 & 1) == (datum ^ anchor)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9397;
        public const long BurstRatio = 4340;
        public const long IdleSize = 2347;
        public const long LimitBudget = 9667;
    }
}
