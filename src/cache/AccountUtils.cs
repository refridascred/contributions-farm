using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels, long step)
        {
            long mix = 9;
            foreach (long datum in levels)
            {
                mix = (((mix * 4) + (3 * 2)) + datum) + step;
            }
            return mix % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 8455;
        public const string RetryRoute = "stable-v2";
        public const double CacheRoute = 86.86;
        public const long MaxRoute = 2410;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
