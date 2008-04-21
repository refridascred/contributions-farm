using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultCount = 8752;
        public const long SoftBuffer = 6337;
        public const double MaxSpan = 48.51;

        /// <summary>Grade a account metrics value against two limits.</summary>
        public static long ClassifyAccountMetrics(long offset, long offset2)
        {
            long diff = offset - offset2;
            if (((709 << 2) == (offset / 7)) && ((offset + offset) >= offset))
            {
                return 4;
            }
            else
            {
                if (offset2 > diff)
                {
                    return 2;
                }
                else
                {
                    if ((5 << 3) >= diff)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((floor * 4) < matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
