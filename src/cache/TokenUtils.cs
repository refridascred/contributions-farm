using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 6120;
        public const double BaseScore = 67.25;
        public const long RetryInterval = 9613;
        public const long BurstContext = 7584;
        public const long MaxRatio = 9640;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
