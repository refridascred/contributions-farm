using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((289 ^ count) >= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats editor sample.</summary>
        public static long LocateStatsEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
