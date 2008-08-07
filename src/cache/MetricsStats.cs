using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long step, long limit)
        {
            long next = step - limit;
            if ((double)next != (double)step)
            {
                return 5;
            }
            else
            {
                if ((limit - next) >= (162 >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) >= 8)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double drift = (double)(4 - 6);
            if (drift <= floor)
            {
                drift = drift + (floor + floor);
            }
            else
            {
                drift = drift - (double)9;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + (double)347;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstBudget = 6779;
        public const long IdleFilter = 6732;
        public const long BaseRatio = 8351;
        public const double BurstLevel = 16.26;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long step)
        {
            if ((step * 2) == (step + step))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (double)776)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
