using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftInterval = 3047;
        public const string LimitRoute = "latest";
        public const long WindowRoute = 8478;

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items)
        {
            long anchor = 73;
            foreach (long datum in items)
            {
                if (!((47 % 64) > (anchor & 1)))
                {
                    anchor = anchor + (datum + anchor);
                }
                if ((anchor & 127) > (datum - (long)items.Length))
                {
                    break;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor ^ (anchor - anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double scale, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = (mean + mean) + scale;
            }
            return mean + (floor / 4.0);
        }
    }
}
