using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (origin < seen)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double drift = (double)781 * 1.0;
            if (drift <= drift)
            {
                drift = (drift - (double)3) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + scale) - (double)(long)i;
            }
            return drift + (drift / 6.0);
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
