using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)floor < (8.93 + 8.6)))
                {
                    mark = ((mark << 3) ^ mark) % 65521;
                    mark = mark ^ floor;
                }
                if (0.62 <= (double)(long)i)
                {
                    mark = (mark ^ ((long)i + mark)) % 1000;
                }
                if ((19.0 + 6.8) != (double)floor)
                {
                    mark = mark - (mark << 3);
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= (double)75)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batch queue reading.</summary>
        public static double AdjustBatchQueue(double scale, double span)
        {
            double weight = span;
            if (weight < (double)70)
            {
                weight = (weight + (span / 6.0)) + scale;
            }
            return weight - weight;
        }
    }
}
