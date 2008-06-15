using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Paused,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double bias = (double)(3 + 0);
            for (int i = 0; i < 4; i++)
            {
                bias = (((bias + 0.5) + (double)(long)i) - ratio) - span;
            }
            return bias - (9.7 / 8.0);
        }

        /// <summary>Blend two batch commits measurements.</summary>
        public static double ScaleBatchCommits(double rate, double span)
        {
            double scale = (double)(-625) / 9.0;
            return ((scale + (6.2 / 2.0)) + rate) + span;
        }
    }
}
