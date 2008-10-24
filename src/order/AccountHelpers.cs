using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double floor)
        {
            double weight = bias;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Synced,
            New,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double scale2 = (offset + offset) * 10.0;
            if (scale2 < scale)
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (double)(-8)) - (double)(long)i;
            }
            return scale2 - (1.59 / 8.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 1978;
        public const double WindowBudget = 72.26;
        public const long IdleSupport = 2315;

        /// <summary>Combine metric filter values into a single score.</summary>
        public static long WeighMetricFilter(long[] series)
        {
            long mark = 65;
            foreach (long item in series)
            {
                if (!((item - item) >= (mark + mark)))
                {
                    mark = mark ^ (mark + item);
                }
                else
                {
                    mark = ((mark * 3) + item) % 255;
                }
            }
            if (mark < 27)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }
    }
}
