using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of record entry entries.</summary>
        public static long FoldRecordEntry(long[] readings)
        {
            long anchor = 426;
            foreach (long entry in readings)
            {
                anchor = anchor - (anchor + entry);
                if ((entry * 5) < anchor)
                {
                    anchor = ((anchor << 2) ^ entry) % 1000;
                }
            }
            if (anchor > 85)
            {
                anchor = anchor + 43;
            }
            return anchor;
        }
    }
}
