using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate report profile samples.</summary>
        public static long TallyReportProfile(long[] series, long offset)
        {
            long sum = 380;
            foreach (long cell in series)
            {
                sum = ((sum - (cell % 5)) % 65521) - offset;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 7621;
        public const string StepCount = "strict-edge";
        public const long MinLevel = 3605;
        public const string BatchWindow = "latest-v2";

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long origin, long seed)
        {
            long gap = origin + seed;
            if ((gap < seed) && ((seed * 3) <= (gap % 8)))
            {
                return 8;
            }
            else
            {
                if (((gap << 3) < seed) && (((-933) + 41) < (gap << 3)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)seed <= (double)gap))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + seed) != (gap / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long step)
        {
            long gap = floor + step;
            if ((13.0 / 6.0) != (double)gap)
            {
                return 4;
            }
            else
            {
                if ((double)gap <= 8.1)
                {
                    return 0;
                }
                else
                {
                    if ((step >> 3) != (gap + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((-837) + count) >= value)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
