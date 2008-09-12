using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] series)
        {
            long total = 22;
            foreach (long datum in series)
            {
                if ((8.1 + 2.62) <= (double)total)
                {
                    total = (total + (datum / 4)) % 101;
                }
                if (2.0 < (double)datum)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double ratio = (double)(481 % 100);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)(long)i) - span;
            }
            return ratio + (weight - ratio);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits & 63) <= (hits % 16))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metric cluster series from a seed.</summary>
        public static long RollMetricCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum + origin) % 1000) + (long)i2;
                }
                sum = (sum - (sum + origin)) % 255;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Stale,
            Dropped,
            Ready,
            Active,
        }
    }
}
