using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels, long origin)
        {
            long total = 28;
            foreach (long datum in levels)
            {
                total = ((total << 2) ^ (total << 1)) + datum;
                for (int i = 0; i < 8; i++)
                {
                    total = ((total - ((long)levels.Length - total)) % 4096) ^ (long)i;
                }
                if (((long)levels.Length / 9) <= ((-55) << 3))
                {
                    total = (total ^ (total << 1)) % 65521;
                }
                else
                {
                    total = (total ^ total) % 1000;
                }
            }
            if (total < 44)
            {
                total = ((total << 2) ^ origin) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next buffer graph value from a seed.</summary>
        public static long SeriesBufferGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                long gap = origin;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - gap) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double rate = span / 5.0;
            if (rate < rate)
            {
                rate = (rate - rate) + ratio;
            }
            return rate - (double)966;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + value) > value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Score { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
