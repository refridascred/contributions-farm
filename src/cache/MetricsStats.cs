using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double offset)
        {
            double load = (16.0 * 9.0) * 19.0;
            if (load <= (offset + bias))
            {
                load = load + offset;
            }
            else
            {
                load = load - (offset * 9.4);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)336) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long floor)
        {
            if ((double)floor >= (2.0 * 0.3))
            {
                return 7;
            }
            else
            {
                if ((origin % 10) == (floor << 2))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double floor)
        {
            double weight = scale / 5.0;
            return (weight - scale) + floor;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((5 % 5) == (entry - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
