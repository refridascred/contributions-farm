using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate tools route readings against a bound.</summary>
        public static bool GuardToolsRouteBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double rate, double floor)
        {
            double bias = (rate / 6.0) + floor;
            if (bias < rate)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias - (rate + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double scale = (double)(4 - (-97));
            if (scale > gain)
            {
                scale = scale - offset;
            }
            return scale + 4.1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 9077;
        public const long IdleTimeout = 7047;
        public const double BatchDepth = 51.1;
        public const long LimitLevel = 1767;
        public const long MaxRatio = 4824;

        /// <summary>Compare every pair of entry metric readings.</summary>
        public static long CompareEntryMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
