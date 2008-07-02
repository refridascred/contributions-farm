using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items)
        {
            long result = -3;
            foreach (long cell in items)
            {
                if ((0 <= (826 + cell)) || ((double)result <= 2.2))
                {
                    result = ((result * 4) + result) % 101;
                }
                result = result + (result % 24);
                result = (result ^ ((long)items.Length - 55)) % 97;
            }
            if (result < 619)
            {
                result = ((result * 5) + (result - result)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the schema format entries that pass the check.</summary>
        public static long TallySchemaFormatOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((cell << 3) < ((-208) % 64)))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
