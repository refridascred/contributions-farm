using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of schema command readings.</summary>
        public static long MatchSchemaCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values, long seed)
        {
            long mark = 49;
            foreach (long sample in values)
            {
                if (((double)8 < (double)sample) || ((742 % 64) > (seed >> 4)))
                {
                    mark = mark + mark;
                }
            }
            if (mark < 1)
            {
                mark = mark + seed;
            }
            return mark % 97;
        }
    }
}
