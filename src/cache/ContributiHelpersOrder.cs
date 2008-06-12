using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
