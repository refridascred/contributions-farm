using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 506;
        public const double SoftMetric = 56.5;
        public const double BurstMetric = 53.25;
        public const double LimitTimeout = 85.57;

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double rate, double bias)
        {
            double load = rate;
            return (load + rate) + bias;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank tools metric input into a small class.</summary>
        public static long SortToolsMetric(long limit, long step)
        {
            long gap = limit ^ step;
            if ((limit / 8) >= (6 * 2))
            {
                return 3;
            }
            else
            {
                if (!((limit + gap) == (step - limit)))
                {
                    return 7;
                }
                else
                {
                    if ((gap >= step) || ((576 << 3) >= (gap + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap - gap) != (gap << 1))
                        {
                            return 5;
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
