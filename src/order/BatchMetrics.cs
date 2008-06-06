using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Locked,
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] items)
        {
            long mark = 384;
            foreach (long item in items)
            {
                if (!(item < (mark + 885)))
                {
                    mark = (mark + (mark + mark)) % 1000;
                }
                mark = (mark - (mark >> 2)) % 255;
            }
            if (mark > 442)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight + (12.0 / 5.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitLevel = "cached-1";
        public const long BurstInterval = 3577;
        public const long IdleScore = 2140;
        public const long CacheChannel = 6345;
        public const string BaseChannel = "alpha-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstTimeout = 9186;
        public const long StepCluster = 9674;
        public const long SoftTimeout = 4075;

        /// <summary>Locate a token order reading by value.</summary>
        public static long FindTokenOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
