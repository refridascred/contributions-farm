using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double mean = (offset + ratio) + (offset * 15.0);
            if (mean > offset)
            {
                mean = mean - (mean + 0.44);
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (ratio * 2.36)) + (double)(long)i;
            }
            return mean - (offset - mean);
        }

        /// <summary>Derive the next layout cache value from a seed.</summary>
        public static long RollLayoutCache(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = score - (target >> 4);
                score = (score + (target ^ target)) % 255;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchSpan = "strict-edge";
        public const long LimitRoute = 7964;
        public const long IdleRoute = 6032;
        public const double StepRoute = 3.58;
        public const string BatchRatio = "local-1";

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double load = (offset * 6.7) + (offset - offset);
            if (load > offset)
            {
                load = load - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + scale;
        }
    }
}
