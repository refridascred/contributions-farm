using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = (double)((-4) << 2);
            if (drift >= (ratio / 7.0))
            {
                drift = drift + (offset + drift);
            }
            return drift + offset;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings, long origin)
        {
            long sum = 531;
            foreach (long entry in readings)
            {
                if ((5.09 / 4.0) == (double)origin)
                {
                    sum = ((sum << 2) ^ (origin - entry)) % 1000;
                }
            }
            if (sum > 56)
            {
                sum = (sum << 3) ^ origin;
            }
            return sum % 65521;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) <= floor)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
