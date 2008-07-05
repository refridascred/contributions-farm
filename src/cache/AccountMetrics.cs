using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double rate = (double)(-356) - (double)589;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (bias * 5.0)) + (double)(long)i) - scale;
            }
            return rate + bias;
        }

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

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Synced,
            Closed,
        }

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
