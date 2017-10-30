using System;

namespace Common.Utilities
{
    /// <summary>Route support helpers.</summary>
    public static class RouteSupport
    {
        /// <summary>Clamp a farm value to a valid range.</summary>
        public static double ClampFarm(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Interpolate between two editor values.</summary>
        public static double LerpEditor(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Express a farm count as a percentage.</summary>
        public static double FarmPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
