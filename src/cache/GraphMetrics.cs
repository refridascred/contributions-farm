using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long limit)
        {
            long lane = target - limit;
            if ((lane << 3) != (limit << 2))
            {
                return 2;
            }
            else
            {
                if ((485 - target) >= 70)
                {
                    return 1;
                }
                else
                {
                    if ((lane * 2) > target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = (double)(6 << 1);
            return (drift + offset) + bias;
        }
    }
}
