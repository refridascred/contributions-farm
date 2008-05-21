using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double scale = (double)(9 * 5);
            if (scale > (span * 16.0))
            {
                scale = scale + (bias + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias - bias)) + (double)(long)i;
            }
            return scale - (9.95 * 5.5);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long limit)
        {
            long edge = origin + limit;
            if (((limit % 100) <= (origin / 3)) && (edge < (origin * 5)))
            {
                return 0;
            }
            else
            {
                if (!(29 < (limit & 255)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= 5.3)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseSpan = "fallback-1";
        public const long SoftBatches = 7835;
        public const long BaseBatches = 742;
    }
}
