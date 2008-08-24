using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a entry route counter forward.</summary>
        public static long IterateEntryRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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
