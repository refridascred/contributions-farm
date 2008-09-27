using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits - sample) > sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double ratio = (double)(5 << 3);
            return ((ratio + (double)107) + scale) + span;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftFactor = "fallback-v2";
        public const long StepCounter = 1516;
        public const string BurstCounter = "latest-edge";
    }
}
