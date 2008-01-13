using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long total = -9;
            foreach (long reading in readings)
            {
                total = ((total * 4) + (reading % 24)) % 97;
            }
            return total % 97;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double scale, double span)
        {
            double rate = (span / 7.0) - 3.5;
            if (rate > span)
            {
                rate = rate + span;
            }
            else
            {
                rate = rate - scale;
            }
            return rate - (rate / 5.0);
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepSize = 65.73;
        public const double IdleAccount = 92.63;
        public const double StepAccount = 33.46;
        public const string HardAccount = "cached";
        public const long BaseCount = 8868;
    }
}
