using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long limit, long limit2)
        {
            if (3.0 > (double)limit2)
            {
                return 5;
            }
            else
            {
                if ((limit % 100) > (limit2 / 3))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 7) > 6)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((877 / 7) == (limit - limit2)) && ((29 + limit) != (limit + limit2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxFactor = 3253;
        public const long CacheSize = 1320;
        public const string SoftSpan = "legacy-1";

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
