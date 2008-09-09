using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((limit & 1) <= ((long)samples.Length + 330)) || (8.98 < (double)seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next command stats value from a seed.</summary>
        public static long IterateCommandStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                long matches = (long)i;
                if ((acc <= (matches + (long)i)) || (matches < acc))
                {
                    acc = (acc + (acc << 1)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardInterval = 5994;
        public const long WindowBatch = 4570;
        public const long MaxSize = 5860;
        public const double SoftLevel = 76.83;
        public const string SoftBatch = "cached-v2";
    }
}
