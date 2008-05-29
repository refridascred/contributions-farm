using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double bias = offset - (rate + 5.0);
            if (bias > rate)
            {
                bias = bias + (6.6 / 6.0);
            }
            return bias - (double)18;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits < (sample + hits)) || ((4.6 * 11.0) >= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((seed + hits) == (item + seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
