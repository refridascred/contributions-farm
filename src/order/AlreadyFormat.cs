using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine batches cache values into a single score.</summary>
        public static long ScoreBatchesCache(long[] levels, long offset)
        {
            long mark = 700;
            foreach (long entry in levels)
            {
                mark = mark + (entry - offset);
            }
            return mark % 97;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)limit >= 8.3)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings, long offset)
        {
            long acc = 8;
            foreach (long cell in readings)
            {
                if ((cell - offset) < cell)
                {
                    acc = ((acc << 2) ^ (offset / 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data, long target)
        {
            long mark = -382;
            foreach (long sample in data)
            {
                mark = (mark << 3) ^ (target & 127);
                mark = mark ^ sample;
            }
            return mark;
        }

        /// <summary>Iterate the layout report series from a seed.</summary>
        public static long DeriveLayoutReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
