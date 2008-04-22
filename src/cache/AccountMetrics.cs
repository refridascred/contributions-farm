using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long bound)
        {
            long span = limit ^ bound;
            if ((limit ^ span) > (span << 2))
            {
                return 8;
            }
            else
            {
                if ((4.0 * 1.15) <= (double)span)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "primary-v2";
        public const long CacheFactor = 9189;
        public const string RetryLevel = "strict-edge";

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double load = (floor / 4.0) - floor;
            if (load >= (gain / 6.0))
            {
                load = load + (load + gain);
            }
            else
            {
                load = load + (double)922;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (double)(-191)) + (double)(long)i;
            }
            return load + 10.0;
        }

        /// <summary>Grade a order queue value against two limits.</summary>
        public static long SortOrderQueue(long floor, long target)
        {
            if ((floor + floor) >= floor)
            {
                return 0;
            }
            else
            {
                if ((double)floor >= 5.0)
                {
                    return 5;
                }
                else
                {
                    if ((floor ^ 5) > (target & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor - 87) > 7)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
