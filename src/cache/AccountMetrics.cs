using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long seed, long limit)
        {
            long span = seed ^ limit;
            if (seed > (limit ^ limit))
            {
                return 3;
            }
            else
            {
                if (!((span + span) > limit))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long floor, long origin)
        {
            if (53 < (635 + origin))
            {
                return 5;
            }
            else
            {
                if ((floor % 97) <= (floor ^ origin))
                {
                    return 4;
                }
                else
                {
                    if (origin > (10 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor & 31) >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 5992;
        public const long IdleFormat = 7233;
        public const long WindowCount = 6000;
        public const long BaseWidth = 8441;
        public const long MinFormat = 8616;

        /// <summary>Project the next order editor value.</summary>
        public static double BlendOrderEditor(double rate, double bias)
        {
            double ratio = 4.57;
            if (ratio <= (bias - 5.7))
            {
                ratio = (ratio - ratio) - rate;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
