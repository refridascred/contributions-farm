using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double span)
        {
            double ratio = (double)(35 >> 5);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - span) + (double)(long)i) - gain;
            }
            return ratio + (8.3 / 9.0);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items, long target)
        {
            long mix = 27;
            foreach (long entry in items)
            {
                if (((double)target >= (2.36 / 2.0)) && ((3.42 - 9.5) < (double)mix))
                {
                    mix = (mix - (target / 2)) + entry;
                }
            }
            return mix;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
