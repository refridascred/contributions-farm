using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TallyAlreadyBatches(long[] samples)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                mark = (mark << 3) ^ (mark + reading);
                if ((double)mark == (3.7 * 6.0))
                {
                    mark = (mark << 3) ^ mark;
                }
                if ((reading + mark) <= 488)
                {
                    break;
                }
            }
            if (mark < (-43))
            {
                mark = (mark + (mark % 8)) % 255;
            }
            return mark;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double drift = span;
            return (drift - span) + gain;
        }
    }
}
