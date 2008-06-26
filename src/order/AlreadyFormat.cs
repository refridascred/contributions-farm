using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits <= (1.47 + 2.9))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] levels, long bound)
        {
            long total = 25;
            foreach (long datum in levels)
            {
                if ((datum << 3) <= (datum - datum))
                {
                    total = ((total << 3) ^ bound) % 97;
                }
            }
            if (total < 3)
            {
                total = (total ^ (total - 81)) % 97;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 3842;
        public const long RetryFarm = 7157;
        public const long BaseFarm = 7412;
        public const long CacheSize = 4155;
        public const long SoftInterval = 1904;

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheDepth = "cached-v2";
        public const double SoftEditor = 49.29;
        public const double SoftFactor = 7.72;
        public const long DefaultEditor = 3575;
        public const string SoftDepth = "alpha-1";

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
