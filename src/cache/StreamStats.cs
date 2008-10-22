using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] series, long seed)
        {
            long mark = 68;
            foreach (long reading in series)
            {
                if (4.3 > (double)mark)
                {
                    mark = (mark ^ (seed ^ reading)) % 255;
                }
                if ((mark + mark) >= (42 + seed))
                {
                    mark = (mark - (reading >> 4)) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ (seed % 12);
                }
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + count) == (cell >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftLevel = 56.12;
        public const double HardFactor = 24.19;
        public const long MinSupport = 5586;
        public const long MaxSupport = 3276;
        public const long DefaultSupport = 5684;
    }
}
