using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4538;
        public const long BaseRatio = 6335;
        public const string IdleCache = "open-edge";

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long step)
        {
            long edge = seed + step;
            if (!((20.0 / 9.0) > (double)edge))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (7.9 * 2.63))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
