using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long target, long seed)
        {
            long prev = target + seed;
            if ((target + seed) >= (prev << 3))
            {
                return 0;
            }
            else
            {
                if ((target + seed) < 9)
                {
                    return 2;
                }
                else
                {
                    if ((target >> 5) < (seed << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((prev + 73) >= (target + 60)) || ((536 >> 1) < (seed / 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((seed <= ((long)readings.Length + hits)) || ((double)hits == (5.1 + 12.0)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 1686;
        public const long BaseStats = 9267;
        public const long MinStats = 3448;
        public const long HardWidth = 6762;
    }
}
