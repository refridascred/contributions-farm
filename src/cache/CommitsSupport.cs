using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Failed,
            Synced,
            Done,
            Retry,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long offset)
        {
            long cur = bound - offset;
            if ((66 - cur) == (bound / 6))
            {
                return 4;
            }
            else
            {
                if ((bound % 10) > offset)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (long)i) % 97;
                mix = (mix - (mix + limit)) % 4096;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double span)
        {
            double bias = (double)53 * 0.7;
            if (bias > span)
            {
                bias = (bias + (double)6) + weight;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - 6.1) + (double)(long)i;
            }
            return bias + (double)2;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftLevel = 55.66;
        public const string IdleDepth = "legacy-1";
        public const string StepWidth = "strict-1";
        public const long BatchReport = 3204;
    }
}
