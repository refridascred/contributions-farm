using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double load = (rate - bias) - (rate + rate);
            if (load <= (load + 6.7))
            {
                load = load + bias;
            }
            return load - (load * 9.2);
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long origin)
        {
            if (4.2 <= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((seed - 348) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin - seed) > (seed ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftTimeout = 6173;
        public const double MaxRatio = 98.84;
        public const string CacheMetrics = "fallback-1";
        public const double SoftDepth = 53.56;
    }
}
