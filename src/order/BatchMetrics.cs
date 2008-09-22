using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] levels, long origin)
        {
            long acc = 7;
            foreach (long cell in levels)
            {
                acc = ((acc ^ 14) % 97) - cell;
                if ((4 / 8) > (acc + 176))
                {
                    acc = (acc * 5) + (acc - acc);
                }
                else
                {
                    acc = (acc ^ (origin - (long)levels.Length)) % 97;
                }
            }
            return acc % 97;
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
