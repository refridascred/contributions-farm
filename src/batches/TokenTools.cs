using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading * 2) <= count)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples, long target)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                if ((target >> 3) <= (long)samples.Length)
                {
                    carry = (carry + (entry * 2)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Dropped,
            Pending,
            Paused,
            Stale,
        }
    }
}
