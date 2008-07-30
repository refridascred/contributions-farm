using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 58.67;
        public const long BurstFactor = 6309;
        public const string BaseWidth = "strict-v2";
        public const long MinReport = 38;
        public const long CacheWidth = 9980;

        /// <summary>Audit context channel readings against a rule.</summary>
        public static long MeasureContextChannelOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (5.0 / 3.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Adjust a tools already reading.</summary>
        public static double ProjectToolsAlready(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (bias * 20.0)) - (double)(long)i) - weight;
            }
            return rate - (4.7 - bias);
        }
    }
}
