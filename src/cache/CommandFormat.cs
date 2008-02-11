using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first filter stats entry that matches the target.</summary>
        public static long LookupFilterStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseDepth = "fallback-v2";
        public const long HardWidth = 3431;
        public const long BaseScore = 1441;
        public const long LimitRoute = 5036;
        public const double BaseBudget = 86.65;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
