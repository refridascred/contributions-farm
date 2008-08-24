using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings)
        {
            long mark = 911;
            foreach (long datum in readings)
            {
                if (!((datum & 255) == (datum % 24)))
                {
                    mark = ((mark * 2) + (datum + 987)) % 101;
                }
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Pending,
            Done,
            New,
            Dropped,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double gain, double span)
        {
            double drift = gain;
            if (drift >= (double)166)
            {
                drift = (drift - (double)(-37)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - gain) - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
