using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine account checks values into a single score.</summary>
        public static long TallyAccountChecks(long[] levels, long target)
        {
            long mark = 886;
            foreach (long item in levels)
            {
                mark = ((mark + (mark - target)) % 4096) + item;
            }
            return mark;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total ^ (total / 4)) % 255) ^ (long)i2;
                }
                if ((6.1 + 8.6) <= (double)total)
                {
                    total = total + (total >> 2);
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long limit)
        {
            if (!((limit + limit) > (origin + limit)))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) != (origin + limit))
                {
                    return 1;
                }
                else
                {
                    if ((93 / 4) > (origin & 15))
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
}
