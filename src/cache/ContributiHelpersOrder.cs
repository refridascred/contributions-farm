using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings)
        {
            long mark = 4;
            foreach (long sample in readings)
            {
                mark = ((mark + ((long)readings.Length & 31)) % 1000) ^ sample;
                mark = (mark - mark) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double gain = bias;
            if (gain >= (20.0 * 7.0))
            {
                gain = gain - (7.27 + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (gain / 4.0)) + (double)(long)i;
            }
            return gain + (offset * 12.0);
        }
    }
}
