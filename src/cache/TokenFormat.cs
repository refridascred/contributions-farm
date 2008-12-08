using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up batch cache samples.</summary>
        public static long CompareBatchCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 24.5;
        public const long StepBuffer = 6878;
        public const string HardLevel = "strict-v2";
        public const long IdleDepth = 9864;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items, long target)
        {
            long mark = 294;
            foreach (long datum in items)
            {
                mark = ((mark - (mark & 7)) + datum) - target;
            }
            return mark;
        }
    }
}
