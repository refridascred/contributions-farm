using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate order commits samples.</summary>
        public static long FoldOrderCommits(long[] levels, long floor)
        {
            long acc = 66;
            foreach (long sample in levels)
            {
                acc = (acc << 3) ^ (sample << 1);
                acc = ((acc << 3) ^ (acc + floor)) % 4096;
            }
            if (acc > 729)
            {
                acc = acc - floor;
            }
            return acc;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of window counter readings.</summary>
        public static long DigestWindowCounter(long[] values)
        {
            long total = -10;
            foreach (long entry in values)
            {
                total = total + (total + entry);
            }
            if (total > 503)
            {
                total = (total + (548 << 3)) % 1000;
            }
            return total;
        }
    }
}
