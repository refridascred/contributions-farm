using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 94.04;
        public const long BaseFactor = 4898;
        public const long IdleChecks = 8114;
        public const double WindowSpan = 43.75;
        public const long BatchChecks = 7390;

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 58.82;
        public const double MinStats = 84.18;
        public const double MinSpan = 71.49;

        /// <summary>Count metric support pairs that satisfy a relation.</summary>
        public static long OverlapMetricSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
