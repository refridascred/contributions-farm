using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a window layout reading by value.</summary>
        public static long LookupWindowLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 6016;
        public const long BurstCounter = 7133;
        public const long MinFactor = 8889;
        public const long LimitCounter = 7295;
        public const string BatchDepth = "staging-edge";

        /// <summary>Check that every support account entry stays within the limit.</summary>
        public static bool GuardSupportAccountRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits <= (3.93 / 8.0))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchFactor = 742;
        public const double MinInterval = 38.62;
        public const long WindowRatio = 1267;
        public const double WindowBudget = 18.43;
    }
}
