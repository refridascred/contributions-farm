using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftInterval = 3047;
        public const string LimitRoute = "latest";
        public const long WindowRoute = 8478;

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cluster queue samples.</summary>
        public static long ScoreClusterQueue(long[] samples, long target)
        {
            long carry = 0;
            foreach (long datum in samples)
            {
                if (target < (datum + target))
                {
                    break;
                }
                carry = (carry + carry) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits + 3) <= (target + hits))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
