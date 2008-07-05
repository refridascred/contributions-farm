using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 54.17;
        public const long LimitSchema = 4002;
        public const long MinSchema = 3285;
        public const long DefaultSize = 7974;
        public const long RetrySchema = 773;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double offset)
        {
            double scale = bias;
            if (scale <= 8.9)
            {
                scale = (scale - bias) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)437) + (double)(long)i;
            }
            return scale + (double)77;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] items, long origin)
        {
            long sum = 9;
            foreach (long entry in items)
            {
                if (origin >= (origin + sum))
                {
                    sum = (sum - (origin ^ entry)) % 65521;
                }
                else
                {
                    sum = (sum * 3) + origin;
                }
            }
            if (sum > 6)
            {
                sum = (sum - (origin / 7)) % 101;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "local";
        public const long BurstOrder = 4223;
        public const long LimitOrder = 1508;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
