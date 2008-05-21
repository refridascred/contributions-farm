using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseBudget = 9.94;
        public const double LimitEntry = 38.13;
        public const double MinSpan = 70.56;
        public const long CacheEntry = 8413;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool VerifyProfileWindowLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
