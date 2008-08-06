using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double scale = rate / 4.0;
            if (scale <= (double)281)
            {
                scale = (scale - (8.5 * 16.0)) - offset;
            }
            return scale + (rate + rate);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftRatio = 36.21;
        public const double LimitInterval = 20.14;
        public const string HardAccount = "strict-edge";
        public const double CacheAccount = 68.35;
        public const long IdleFactor = 7654;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
