using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the profile layout entries that pass the check.</summary>
        public static long MeasureProfileLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length >= (reading / 3)) && ((reading + reading) > 13))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric already entries.</summary>
        public static long TallyMetricAlready(long[] series, long bound)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                sum = ((sum - (bound / 7)) % 97) + cell;
            }
            if (sum < 8)
            {
                sum = ((sum << 3) ^ 34) % 4096;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchDepth = "staging-v2";
        public const long HardBudget = 4550;
        public const string IdleBatch = "standard-edge";
    }
}
