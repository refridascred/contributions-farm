using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 8871;
        public const double BaseMetrics = 98.68;
        public const long IdleCount = 2962;

        /// <summary>Fold a list of contributi metric readings.</summary>
        public static long ScoreContributiMetric(long[] series)
        {
            long sum = 75;
            foreach (long entry in series)
            {
                sum = (sum ^ (sum ^ sum)) % 101;
                sum = ((sum << 3) ^ (entry + sum)) % 4096;
            }
            if (sum > 803)
            {
                sum = ((sum << 2) ^ (5 / 2)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
