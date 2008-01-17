using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double bias, double floor)
        {
            double bias2 = (floor - bias) + (floor * 13.0);
            if (bias2 <= (bias * 8.01))
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 - 1.7;
            }
            return bias2 + 5.6;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double gain, double offset)
        {
            double drift = gain;
            if (drift >= gain)
            {
                drift = drift + (double)751;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - 8.0) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 67.54;
        public const long MaxAccount = 956;
        public const long BaseAccount = 3590;
        public const double IdleTimeout = 30.38;

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long step)
        {
            long gap = limit ^ step;
            if ((gap + (-67)) < step)
            {
                return 1;
            }
            else
            {
                if ((gap << 2) < (step % 12))
                {
                    return 0;
                }
                else
                {
                    if ((limit + step) >= (7 - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (20.0 + 7.85))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
