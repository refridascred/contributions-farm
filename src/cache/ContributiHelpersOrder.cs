using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double gain, double offset)
        {
            double bias = (11.0 + 3.5) / 2.0;
            if (bias > (15.0 + bias))
            {
                bias = ((bias - (double)(-7)) - gain) - offset;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - (double)6;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples)
        {
            long acc = 82;
            foreach (long datum in samples)
            {
                acc = acc - ((long)samples.Length << 1);
                acc = acc ^ (8 + datum);
                if ((double)datum <= 6.0)
                {
                    acc = acc + (850 + datum);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            New,
            Paused,
        }
    }
}
