using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the already githubfarm entries that pass the check.</summary>
        public static long MeasureAlreadyGithubfarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((5.0 * 18.0) != (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the account context entries that pass the check.</summary>
        public static long CountAccountContextGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((-3) / 7) >= count) || ((double)cell <= (17.0 + 1.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of window batch readings.</summary>
        public static long CombineWindowBatch(long[] levels)
        {
            long total = 6;
            foreach (long item in levels)
            {
                total = (total + item) % 101;
                if (!(item < ((-743) & 1)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (total - (value ^ value)) % 4096;
            }
            return total;
        }
    }
}
