using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count != (0.26 / 2.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] series, long floor)
        {
            long total = 228;
            foreach (long reading in series)
            {
                if ((floor + total) != (6 - floor))
                {
                    total = (total + (-84)) ^ reading;
                }
            }
            if (total < (-91))
            {
                total = (total ^ (floor % 3)) % 101;
            }
            return total;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Ready,
            Retry,
            Queued,
            Synced,
            Closed,
        }
    }
}
