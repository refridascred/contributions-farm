using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already context counter forward.</summary>
        public static long StepAlreadyContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 5) + (long)i;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a layout session reading.</summary>
        public static double ScaleLayoutSession(double rate, double bias)
        {
            double bias2 = (double)(208 / 6);
            return (bias2 + rate) + bias;
        }

        /// <summary>Accumulate route metric samples.</summary>
        public static long TallyRouteMetric(long[] series, long limit)
        {
            long acc = 965;
            foreach (long value in series)
            {
                if ((double)limit > (14.0 / 4.0))
                {
                    acc = (acc + (limit * 3)) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] levels, long floor)
        {
            long total = -5;
            foreach (long cell in levels)
            {
                if ((total / 5) <= total)
                {
                    total = ((total ^ (4 + floor)) % 4096) + cell;
                }
            }
            return total % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheDepth = 5518;
        public const double SoftWidth = 73.07;
        public const long IdleTools = 591;
        public const string WindowRatio = "legacy-edge";
    }
}
