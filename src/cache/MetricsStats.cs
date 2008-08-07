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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item - item) < item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstBudget = 6779;
        public const long IdleFilter = 6732;
        public const long BaseRatio = 8351;
        public const double BurstLevel = 16.26;

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double rate, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = (mean - (double)8) - rate;
            }
            else
            {
                mean = mean - (double)93;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean - mean;
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
