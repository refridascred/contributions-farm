using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "staging-edge";
        public const double BatchSpan = 43.21;
        public const long HardSupport = 2577;

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

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
