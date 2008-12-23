using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

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

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
