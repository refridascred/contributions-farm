using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((-7) > floor) || ((8 / 2) != (value & 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = (score << 3) ^ (8 * 3);
                score = (score + (limit + limit)) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
