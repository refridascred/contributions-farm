using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 5227;
        public const string IdlePayload = "alpha";
        public const long SoftPayload = 8309;

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 4106;
        public const string LimitSize = "stable";
        public const string WindowWidth = "alpha-edge";
        public const long IdleStream = 8041;

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double scale = weight;
            if (scale <= weight)
            {
                scale = scale + (scale * 3.39);
            }
            else
            {
                scale = scale - (weight / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double load = (double)(-759) - offset;
            return (load + load) + bias;
        }

        /// <summary>Check that every report metrics entry stays within the limit.</summary>
        public static bool VerifyReportMetricsRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double weight = (double)(0 >> 2);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (scale / 3.0)) + (double)(long)i) + floor;
            }
            return weight + (double)40;
        }
    }
}
