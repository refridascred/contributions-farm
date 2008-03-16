using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the farm support entries that pass the check.</summary>
        public static long CountFarmSupportMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits >= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long step, long offset)
        {
            if (16 > (step * 4))
            {
                return 0;
            }
            else
            {
                if ((579 >> 4) > (offset - step))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.25 / 4.0) >= (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "staging";
        public const string MaxLevel = "standard-1";
        public const long LimitCounter = 5655;
        public const double WindowCounter = 66.2;
        public const long HardWidth = 1620;

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 2749;
        public const long MinFactor = 7787;
        public const long LimitSize = 5877;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen + seen) <= target))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
