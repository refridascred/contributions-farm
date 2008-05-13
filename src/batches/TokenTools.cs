using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long total = 2;
            foreach (long datum in readings)
            {
                total = (total + datum) % 101;
            }
            return total % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 634;
        public const double SoftBuffer = 28.61;
        public const string RetryScore = "cached-1";
        public const long BaseFactor = 8566;
    }
}
