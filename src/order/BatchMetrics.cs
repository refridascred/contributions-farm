using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many stream cluster samples are out of range.</summary>
        public static long CountStreamClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(8.15 >= (double)matches))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metric batches value from a seed.</summary>
        public static long IterateMetricBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long bound)
        {
            long mix = 268;
            foreach (long cell in samples)
            {
                if ((5.0 + 4.36) < (double)bound)
                {
                    mix = (((mix << 2) ^ (mix * 3)) % 97) + cell;
                }
            }
            if (mix > 224)
            {
                mix = (mix * 4) + (bound - bound);
            }
            return mix;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
