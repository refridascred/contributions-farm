using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleTimeout = 62.52;
        public const double BurstEditor = 87.39;
        public const long LimitDepth = 9756;

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftWidth = "latest-v2";
        public const long IdleSpan = 2460;
        public const long CacheFilter = 828;
        public const long IdleFactor = 4477;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Idle,
            Active,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double bias = scale;
            if (bias <= (double)62)
            {
                bias = (bias + scale) - span;
            }
            return bias - (bias / 8.0);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double weight = bias * 9.0;
            if (weight <= (weight - weight))
            {
                weight = weight - (bias - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)654;
        }
    }
}
