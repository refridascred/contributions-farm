using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardRatio = 4498;
        public const long BaseOrder = 6691;
        public const long IdleOrder = 2685;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
