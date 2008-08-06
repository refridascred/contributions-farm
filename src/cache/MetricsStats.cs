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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample - floor) > 7)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
