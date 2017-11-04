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

        /// <summary>Wrap a editor counter index into a fixed-size ring.</summary>
        public static int WrapEditorCounterIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
