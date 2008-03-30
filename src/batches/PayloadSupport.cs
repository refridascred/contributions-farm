using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > ratio)
            {
                ratio = (ratio + ratio) + floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + ratio)) - (double)(long)i;
            }
            return ratio + (ratio * 7.0);
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((total / 3) < bound)
                {
                    total = (total * 4) + (84 - bound);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit editor metrics readings against a rule.</summary>
        public static long MeasureEditorMetricsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)(-759) >= (double)tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }
    }
}
