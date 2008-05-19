using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double bias, double offset)
        {
            double load = (double)(-62) + bias;
            if (load > offset)
            {
                load = load - 4.55;
            }
            return load - (load / 4.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSpan = 890;
        public const string RetrySupport = "local-1";
        public const long LimitSupport = 957;
        public const long WindowDepth = 4640;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double floor)
        {
            double bias = scale * 3.2;
            return bias + floor;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
