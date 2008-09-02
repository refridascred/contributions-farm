using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double ratio, double bias)
        {
            double load = bias + (double)903;
            if (load > ratio)
            {
                load = load - load;
            }
            else
            {
                load = load - (ratio / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias - ratio)) - (double)(long)i;
            }
            return load - (load * 18.0);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long seed)
        {
            long anchor = 357;
            foreach (long sample in series)
            {
                if (!((seed - anchor) > 5))
                {
                    anchor = ((anchor * 3) + (sample % 100)) % 255;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ seed) % 4096;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3477;
        public const string IdlePayload = "latest-edge";
        public const string BurstScore = "primary-v2";

        /// <summary>Blend two batch filter measurements.</summary>
        public static double ProjectBatchFilter(double scale, double span)
        {
            double gain = span;
            if (gain < (3.6 - 5.4))
            {
                gain = gain - (double)25;
            }
            else
            {
                gain = gain - (scale * 6.61);
            }
            return gain + 4.0;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
