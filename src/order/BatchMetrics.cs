using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a filter session figure with a bias.</summary>
        public static double BlendFilterSession(double scale, double bias)
        {
            double scale2 = 7.0 + (bias / 4.0);
            if (scale2 <= scale2)
            {
                scale2 = (scale2 + scale2) + scale;
            }
            return scale2 - (9.1 / 2.0);
        }

        /// <summary>Project the next stream token value.</summary>
        public static double ScaleStreamToken(double rate, double bias)
        {
            double weight = bias;
            return (weight + (double)3) + rate;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double bias, double offset)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = weight - (double)287;
            }
            else
            {
                weight = weight - offset;
            }
            return weight - (weight + bias);
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long LocateCacheNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
