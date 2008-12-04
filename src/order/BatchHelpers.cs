using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long mark = -490;
            foreach (long cell in items)
            {
                if (((double)mark <= (8.0 - 1.2)) || ((9.0 * 1.3) < (double)mark))
                {
                    mark = (((mark * 3) + (mark ^ 8)) % 4096) - cell;
                }
            }
            return mark;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double mean = (weight - floor) + (weight * 7.78);
            if (mean >= (weight * 19.0))
            {
                mean = mean + 5.9;
            }
            else
            {
                mean = mean + (double)40;
            }
            return mean + (mean - floor);
        }
    }
}
