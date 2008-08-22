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

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Dropped,
            Retry,
            Active,
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 6613;
        public const long HardContributi = 913;
        public const long LimitBudget = 1105;

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double gain = rate;
            if (gain <= 7.1)
            {
                gain = gain + (double)77;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - span) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
