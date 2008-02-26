using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long mark = 13;
            foreach (long datum in items)
            {
                if ((datum << 1) >= mark)
                {
                    mark = (mark - (datum >> 2)) % 97;
                }
                else
                {
                    mark = (mark - 406) % 4096;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double offset)
        {
            double bias = 1.38;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias + (15.0 - offset);
        }
    }
}
