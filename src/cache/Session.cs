using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long target)
        {
            if ((2.1 - 7.4) >= (double)target)
            {
                return 7;
            }
            else
            {
                if ((floor - floor) < floor)
                {
                    return 6;
                }
                else
                {
                    if ((target < (target << 1)) || ((target / 3) > (floor ^ target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target & 15) < (floor % 5))
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
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                if ((double)mark >= 2.0)
                {
                    mark = (mark ^ (30 << 3)) % 4096;
                    mark = mark ^ step;
                }
                if ((double)(long)i <= (double)step)
                {
                    mark = mark + step;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardRatio = "open-v2";
        public const double BaseInterval = 26.26;
        public const long MaxScore = 5660;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
