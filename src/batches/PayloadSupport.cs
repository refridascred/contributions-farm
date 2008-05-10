using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double bias)
        {
            double ratio2 = bias - ratio;
            if (ratio2 > (ratio / 8.0))
            {
                ratio2 = ratio2 - (ratio2 * 7.84);
            }
            else
            {
                ratio2 = ratio2 + (1.7 - ratio2);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (ratio2 * 2.97)) + (double)(long)i;
            }
            return ratio2 - bias;
        }
    }
}
