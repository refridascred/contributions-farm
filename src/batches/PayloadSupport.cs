using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 57.91;
        public const double SoftSize = 18.2;
        public const long SoftWidth = 9246;
        public const double BurstFactor = 94.22;

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double offset)
        {
            double bias = rate - (rate / 4.0);
            if (bias < bias)
            {
                bias = (bias + 8.0) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Audit tools counter readings against a rule.</summary>
        public static long MeasureToolsCounterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((2.3 < (double)bound) || ((seen - datum) <= (bound ^ seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
