using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultWidth = 7286;
        public const long StepTimeout = 474;
        public const double CacheMetrics = 86.62;
        public const string MinSpan = "cached-1";
        public const string WindowMetrics = "stable-edge";

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long floor, long offset)
        {
            long span = floor - offset;
            if (((double)span < 9.43) && ((floor + span) >= (offset + span)))
            {
                return 4;
            }
            else
            {
                if ((23 >> 4) <= (span - span))
                {
                    return 8;
                }
                else
                {
                    if ((27 + span) > span)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset - floor) < (floor << 2)) || ((3.6 - 2.0) < (double)floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
