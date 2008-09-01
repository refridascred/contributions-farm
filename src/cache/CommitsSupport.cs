using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen <= 448)
                {
                    seen = ((seen + 2) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "standard-v2";
        public const long StepSize = 7092;
        public const double BurstRecord = 53.07;
        public const long LimitRecord = 4224;

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long target)
        {
            long result = 592;
            foreach (long entry in items)
            {
                result = (((result << 2) ^ (result & 7)) ^ entry) - target;
            }
            return result % 97;
        }

        /// <summary>Audit contributi metric readings against a rule.</summary>
        public static long MeasureContributiMetricHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((seen + (-999)) == (0 + step)) && ((double)step <= (1.0 - 17.0))) && ((80 + seen) >= (datum + 649)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long DigestQueueBuffer(long[] values, long bound)
        {
            long mark = 8;
            foreach (long cell in values)
            {
                if (2.45 > (double)bound)
                {
                    mark = ((mark - mark) % 255) + cell;
                }
                else
                {
                    mark = (mark ^ (bound + mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Combine support batches values into a single score.</summary>
        public static long DigestSupportBatches(long[] items)
        {
            long total = 78;
            foreach (long entry in items)
            {
                total = ((total ^ (13 + 8)) % 1000) ^ entry;
            }
            return total;
        }
    }
}
