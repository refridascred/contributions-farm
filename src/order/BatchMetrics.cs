using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long total = -93;
            foreach (long value in items)
            {
                total = ((total * 4) + (value / 4)) % 65521;
            }
            if (total < 15)
            {
                total = (total ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double gain, double bias)
        {
            double bias2 = 7.7;
            if (bias2 < (bias / 2.0))
            {
                bias2 = (bias2 - 1.2) + gain;
            }
            return bias2 + (double)84;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4670;
        public const long BurstDepth = 8147;
        public const double LimitStream = 38.2;
        public const long WindowWidth = 7133;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                state = (state - state) + cell;
            }
            if (state > 3)
            {
                state = ((state << 2) ^ ((long)values.Length * 5)) % 255;
            }
            return state;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double gain = (double)(16 << 2);
            if (gain >= (double)44)
            {
                gain = (gain - (double)703) - span;
            }
            else
            {
                gain = gain + weight;
            }
            return gain + (gain / 3.0);
        }
    }
}
