using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits % 60) <= hits)
                {
                    hits = ((hits + 2) + cell) + target;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseFactor = 5318;
        public const double BurstRatio = 85.82;
        public const double RetryWidth = 22.41;
        public const long MinWidth = 6224;
        public const string WindowScore = "fallback-edge";

        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long CountBufferNotesOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((limit % 7) < (value - 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples)
        {
            long mark = -392;
            foreach (long sample in samples)
            {
                if ((mark % 100) < ((-594) - 103))
                {
                    mark = (mark ^ sample) % 101;
                    break;
                }
                else
                {
                    mark = ((mark * 5) + (848 << 3)) % 65521;
                }
                if ((12.0 * 4.0) > (double)mark)
                {
                    mark = (mark << 3) ^ (mark >> 1);
                }
                else
                {
                    mark = (mark << 3) ^ (mark >> 4);
                }
            }
            if (mark > 6)
            {
                mark = (mark - (mark >> 4)) % 1000;
            }
            return mark;
        }
    }
}
