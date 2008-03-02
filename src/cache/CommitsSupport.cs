using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
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

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double bias)
        {
            double drift = (double)(4 << 2);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias * 16.0)) + (double)(long)i;
            }
            return drift - (bias - weight);
        }
    }
}
