using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double mean = span;
            return (mean + (double)1) + scale;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long mark = 925;
            foreach (long entry in samples)
            {
                mark = (((mark * 2) + 757) % 255) ^ entry;
            }
            return mark % 4096;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Queued,
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long limit, long offset)
        {
            long gap = limit ^ offset;
            if ((gap + limit) <= offset)
            {
                return 0;
            }
            else
            {
                if (offset <= gap)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
