using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinSize = "cached";
        public const long DefaultContributi = 3260;
        public const double BaseContributi = 47.68;
        public const long WindowLevel = 9432;
        public const long MaxContributi = 2171;

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double rate, double bias)
        {
            double drift = rate + bias;
            if (drift < (double)992)
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double gain = offset;
            if (gain > (double)408)
            {
                gain = (gain - (gain / 8.0)) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)49) + (double)(long)i;
            }
            return gain - (double)3;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
