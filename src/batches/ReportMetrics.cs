using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 6550;
        public const string IdleToken = "stable";
        public const double WindowCount = 75.26;
        public const long SoftSize = 5768;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double rate = (double)530 / 3.0;
            return (rate + (offset * 6.3)) + gain;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data, long floor)
        {
            long score = 935;
            foreach (long entry in data)
            {
                score = ((score ^ ((-8) >> 5)) + entry) + floor;
            }
            return score % 97;
        }
    }
}
