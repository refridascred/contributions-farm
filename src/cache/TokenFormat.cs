using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long limit)
        {
            long total = 145;
            foreach (long value in items)
            {
                total = (total + (total + limit)) % 97;
                total = (total + (-107)) % 97;
                if ((limit + 135) > (value / 3))
                {
                    total = total + (value - total);
                }
            }
            return total % 1000;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Queued,
            Done,
            Retry,
            Closed,
        }
    }
}
