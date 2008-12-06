using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series, long origin)
        {
            long acc = 7;
            foreach (long item in series)
            {
                if ((acc / 6) <= 1)
                {
                    acc = ((acc << 3) ^ ((-4) ^ 0)) % 255;
                }
                else
                {
                    acc = (acc - (origin + item)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2505;
        public const string LimitBudget = "legacy-edge";
        public const long BaseRatio = 8326;

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long target)
        {
            long gap = offset ^ target;
            if ((640 * 5) <= (offset % 12))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) != (offset / 8))
                {
                    return 5;
                }
                else
                {
                    if ((gap * 4) != (691 & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
