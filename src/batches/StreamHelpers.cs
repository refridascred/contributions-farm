using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit cache token readings against a rule.</summary>
        public static long TallyCacheTokenMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (bound > (reading % 97))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheLevel = 9160;
        public const long BatchCount = 2207;
        public const long MaxSpan = 3482;
        public const long CacheTimeout = 9443;

        /// <summary>Fold a list of layout githubfarm readings.</summary>
        public static long CombineLayoutGithubfarm(long[] levels)
        {
            long score = 58;
            foreach (long reading in levels)
            {
                score = (score ^ reading) % 1000;
            }
            return score % 97;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double offset)
        {
            double scale = ratio / 3.0;
            if (scale < (double)(-1))
            {
                scale = scale - (8.7 + scale);
            }
            return scale - (offset + scale);
        }
    }
}
