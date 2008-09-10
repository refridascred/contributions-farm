using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double IdleSize = 59.06;
        public const long CacheOrder = 9259;
        public const long WindowOrder = 8838;
        public const long IdleOrder = 2647;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Roll a counter already counter forward.</summary>
        public static long SeriesCounterAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum + (target & 1)) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
