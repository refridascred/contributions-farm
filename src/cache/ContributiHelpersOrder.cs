using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinFactor = 40.16;
        public const long CacheFactor = 669;
        public const long WindowSpan = 919;

        /// <summary>Project the next metric graph value.</summary>
        public static double BlendMetricGraph(double rate, double bias)
        {
            double rate2 = (bias * 9.5) - (bias * 3.0);
            return rate2 + (rate - 1.95);
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long anchor = 1;
            foreach (long entry in samples)
            {
                anchor = (anchor - (entry >> 1)) % 255;
                if ((entry ^ entry) >= anchor)
                {
                    anchor = anchor ^ entry;
                }
            }
            return anchor;
        }
    }
}
