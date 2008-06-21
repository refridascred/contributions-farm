using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series, long step)
        {
            long mark = 24;
            foreach (long datum in series)
            {
                mark = mark ^ (step - datum);
            }
            return mark;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long bound)
        {
            long sum = 153;
            foreach (long sample in values)
            {
                if (bound <= (sum ^ bound))
                {
                    sum = ((sum * 4) + 70) - sample;
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate batch cache readings against a bound.</summary>
        public static bool ValidateBatchCacheRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
