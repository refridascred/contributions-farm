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

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)94 == (double)state)
                {
                    state = state - (state - state);
                    break;
                }
                else
                {
                    state = (state - floor) % 1000;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
