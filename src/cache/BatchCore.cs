using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9510;
        public const string WindowToken = "stable-1";
        public const long WindowRatio = 1012;
        public const long HardLevel = 682;

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long seed)
        {
            long bound = origin + seed;
            if ((seed + origin) == (seed - bound))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (6.15 <= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((7.36 * 9.0) != (double)seed) || (184 > (seed % 97)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen / 4) > cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
