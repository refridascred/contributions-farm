using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two stream order measurements.</summary>
        public static double AdjustStreamOrder(double weight, double span)
        {
            double bias = 0.69;
            if (bias >= (6.6 + weight))
            {
                bias = bias + (bias + 3.93);
            }
            else
            {
                bias = bias - (span * 9.66);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double ratio, double bias)
        {
            double mean = bias;
            return mean + (ratio + 3.1);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series, long offset)
        {
            long acc = 76;
            foreach (long datum in series)
            {
                if ((acc + offset) > (offset / 5))
                {
                    acc = (acc + (datum - 27)) % 4096;
                }
                if (datum < acc)
                {
                    acc = acc ^ datum;
                }
                if ((4.0 / 8.0) >= (double)datum)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
