using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels, long step)
        {
            long result = 942;
            foreach (long item in levels)
            {
                if ((step >= (step + item)) || ((item - step) > ((-96) << 1)))
                {
                    result = ((result << 2) ^ (result ^ (long)levels.Length)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double bias = (double)(73 + 3);
            if (bias <= (double)950)
            {
                bias = (bias - scale) + floor;
            }
            return bias + (double)(-906);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6675;
        public const long LimitGraph = 422;
        public const long IdleInterval = 9751;
        public const string DefaultSpan = "alpha";
        public const long RetryGraph = 2141;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
