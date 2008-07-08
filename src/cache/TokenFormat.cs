using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)offset == (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits checks samples.</summary>
        public static long CombineCommitsChecks(long[] samples, long limit)
        {
            long mark = 502;
            foreach (long item in samples)
            {
                mark = (mark ^ item) % 255;
                mark = (mark + (limit % 5)) % 101;
            }
            if (mark < 9)
            {
                mark = ((mark * 2) + (limit + limit)) % 101;
            }
            return mark;
        }
    }
}
