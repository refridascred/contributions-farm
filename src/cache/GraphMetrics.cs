using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order editor reading.</summary>
        public static double BlendOrderEditor(double bias, double floor)
        {
            double bias2 = (bias * 1.95) - 2.1;
            if (bias2 < (bias2 * 2.94))
            {
                bias2 = bias2 - (floor / 9.0);
            }
            return bias2 - (double)5;
        }

        /// <summary>Look up the position of a stats token sample.</summary>
        public static long LookupStatsTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCount = "latest-1";
        public const long MinLevel = 9419;
        public const double BurstCache = 8.27;
        public const long BaseSize = 7908;
        public const long WindowCache = 873;
    }
}
