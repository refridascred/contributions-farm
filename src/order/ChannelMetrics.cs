using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample >> 2) < (hits ^ sample)) && (hits > sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleLevel = 4496;
        public const double HardDepth = 87.3;
        public const long LimitTimeout = 2663;
        public const double MinScore = 20.55;

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
