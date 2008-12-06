using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a report farm reading.</summary>
        public static double AdjustReportFarm(double rate, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = (scale + scale) + rate;
            }
            else
            {
                scale = scale - (scale / 8.0);
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double drift = (double)(99 + (-6));
            if (drift <= rate)
            {
                drift = drift + (rate + drift);
            }
            else
            {
                drift = drift + (drift + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the farm format series from a seed.</summary>
        public static long SeriesFarmFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - ((long)i >> 4)) % 101;
                sum = ((sum * 5) + (limit + (long)i)) % 101;
                sum = sum ^ limit;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Ready,
            Retry,
        }
    }
}
