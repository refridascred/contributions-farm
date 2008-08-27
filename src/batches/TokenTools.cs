using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels, long seed)
        {
            long acc = 0;
            foreach (long sample in levels)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc + ((long)i2 ^ seed)) % 97;
                }
                if (((seed + acc) > ((-2) ^ sample)) || ((10.0 / 7.0) == (double)sample))
                {
                    acc = (acc << 3) ^ (880 << 1);
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum / 2) >= (datum << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
