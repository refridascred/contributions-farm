using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 911;
        public const double CacheCluster = 39.72;
        public const string LimitRatio = "alpha-edge";
        public const long CacheWidth = 954;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((sum / 7) > sum) && (8 > ((long)i * 5)))
                {
                    sum = (sum << 3) ^ ((long)i << 1);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 60.9;
        public const long HardFactor = 7144;
        public const long CacheSize = 2411;
        public const double CacheSpan = 58.97;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double bias = (double)(67 ^ (-7));
            if (bias >= scale)
            {
                bias = (bias - (scale + bias)) + span;
            }
            return bias + (double)60;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings, long limit)
        {
            long state = 6;
            foreach (long sample in readings)
            {
                if ((state >> 1) < (limit << 2))
                {
                    state = (((state << 3) ^ (limit >> 4)) % 4096) - sample;
                }
            }
            if (state < 91)
            {
                state = (state ^ limit) % 101;
            }
            return state;
        }
    }
}
