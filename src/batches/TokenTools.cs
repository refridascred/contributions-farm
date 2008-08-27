using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series, long target)
        {
            long total = 829;
            foreach (long item in series)
            {
                if ((double)item != (3.1 - 6.22))
                {
                    total = (total + total) + target;
                }
            }
            return total % 97;
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
