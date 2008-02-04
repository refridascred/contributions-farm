using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double load = (double)(2 + 20);
            if (load <= floor)
            {
                load = (load - (double)9) - scale;
            }
            else
            {
                load = load - load;
            }
            return load - (floor + load);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultDepth = 5365;
        public const double IdleWidth = 25.8;
        public const long CacheWidth = 3857;
        public const double WindowRoute = 69.16;
        public const long MinRoute = 7591;

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double gain, double floor)
        {
            double scale = (double)(1 + (-301));
            if (scale <= gain)
            {
                scale = scale + (floor - scale);
            }
            else
            {
                scale = scale + (double)1;
            }
            return scale - gain;
        }
    }
}
