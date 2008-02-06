using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinFactor = 45.13;
        public const long HardFactor = 5955;
        public const long BatchStats = 5189;
        public const long LimitStats = 1261;
    }
}
