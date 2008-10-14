using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double ratio, double offset)
        {
            double rate = (ratio - offset) / 2.0;
            if (rate >= (double)427)
            {
                rate = rate - ratio;
            }
            return rate + rate;
        }

        /// <summary>Measure how many commits tools samples are out of range.</summary>
        public static long AuditCommitsToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) < (entry / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double bias = (weight - weight) + (3.1 * 1.5);
            return bias + floor;
        }
    }
}
