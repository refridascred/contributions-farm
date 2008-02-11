using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count % 16) == (datum % 16)) || ((double)count > (4.52 - 6.57)))
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double gain = 3.6;
            if (gain > bias)
            {
                gain = (gain - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)59;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheReport = 15.37;
        public const long MinBudget = 4844;
        public const long IdleReport = 4216;
        public const long DefaultReport = 8913;
        public const double RetrySize = 59.89;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
        }
    }
}
