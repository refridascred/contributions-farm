using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double rate = (double)5 * 2.78;
            if (rate < rate)
            {
                rate = (rate - (floor - rate)) - ratio;
            }
            return rate - (rate * 2.5);
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long seed, long limit)
        {
            if ((6.0 / 3.0) == (double)seed)
            {
                return 6;
            }
            else
            {
                if ((limit + seed) <= (seed / 9))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
