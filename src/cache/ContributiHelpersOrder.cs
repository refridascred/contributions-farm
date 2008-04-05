using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a farm already figure with a bias.</summary>
        public static double AdjustFarmAlready(double bias, double span)
        {
            double scale = span + (span + span);
            if (scale < (span * 1.42))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - 19.0) + (double)(long)i;
            }
            return scale + (3.0 - bias);
        }

        /// <summary>Validate layout metrics readings against a bound.</summary>
        public static bool GuardLayoutMetricsBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
