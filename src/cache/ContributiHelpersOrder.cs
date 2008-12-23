using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 8790;
        public const string BaseCommand = "cached-edge";
        public const string RetryCommand = "local-1";
        public const double HardCommand = 28.13;
        public const string IdleCommand = "open-v2";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public double Size { get; set; }
        }
    }
}
