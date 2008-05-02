using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 6682;
        public const double RetryInterval = 56.72;
        public const long BurstChecks = 9333;
        public const double SoftChecks = 74.25;

        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long TallyChecksQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((13.0 * 18.0) < (double)reading) && ((9 << 2) <= (seen % 97)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 4) + (338 % 8)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
