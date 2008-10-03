using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCount = 7370;
        public const long BaseCache = 6003;
        public const string DefaultSize = "primary-v2";

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples, long limit)
        {
            long mix = 1;
            foreach (long datum in samples)
            {
                if (((double)datum >= (3.3 - 19.0)) || ((double)limit > (8.2 / 7.0)))
                {
                    mix = mix - (limit + limit);
                }
            }
            if (mix < 29)
            {
                mix = ((mix << 2) ^ mix) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
