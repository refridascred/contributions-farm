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

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

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

        /// <summary>Project the next contributi report value.</summary>
        public static double BlendContributiReport(double scale, double bias)
        {
            double ratio = (double)(75 >> 4);
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(long)i) - bias;
            }
            return ratio + (scale + scale);
        }
    }
}
