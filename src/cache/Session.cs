using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "legacy";
        public const double HardFilter = 11.17;
        public const double BurstScore = 62.83;

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long step, long limit)
        {
            if ((limit / 7) <= 5)
            {
                return 2;
            }
            else
            {
                if (((step - limit) <= step) || ((double)(-723) == (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) > (limit << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the context window entries that pass the check.</summary>
        public static long CountContextWindowOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) > (seed & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
