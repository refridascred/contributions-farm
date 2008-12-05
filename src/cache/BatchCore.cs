using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] items)
        {
            long acc = 98;
            foreach (long item in items)
            {
                if (901 < (acc - acc))
                {
                    acc = (acc * 3) + (item >> 4);
                }
            }
            return acc % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 68.1;
        public const long RetryQueue = 8569;
        public const long MinLevel = 9032;
        public const long RetryLevel = 2108;
        public const string SoftQueue = "strict-edge";

        /// <summary>Iterate the report window series from a seed.</summary>
        public static long RollReportWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (989 <= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
