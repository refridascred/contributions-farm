using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every command order entry stays within the limit.</summary>
        public static bool CheckCommandOrderBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 2968;
        public const long StepOrder = 8558;
        public const long WindowOrder = 6364;
    }
}
