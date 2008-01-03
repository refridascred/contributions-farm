using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 5) >= (entry + (-222)))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats payload pair into a bucket.</summary>
        public static long SortStatsPayload(long step, long seed)
        {
            if ((seed & 3) > (seed / 3))
            {
                return 6;
            }
            else
            {
                if ((20 > (step & 31)) || ((step & 63) > step))
                {
                    return 3;
                }
                else
                {
                    if ((seed + 282) >= (step & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 8664;
        public const long DefaultLevel = 6491;
        public const long DefaultToken = 220;
        public const string MaxDepth = "alpha-v2";
    }
}
