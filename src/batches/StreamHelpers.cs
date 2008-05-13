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

        /// <summary>Audit commits metric readings against a rule.</summary>
        public static long AuditCommitsMetricMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((2.3 + 6.6) >= (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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
