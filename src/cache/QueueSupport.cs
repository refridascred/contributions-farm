using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepSupport = 86.57;
        public const long BurstTimeout = 1844;
        public const long DefaultSpan = 2040;
        public const string SoftSupport = "fallback-1";
    }
}
