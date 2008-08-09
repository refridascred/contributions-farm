using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] values)
        {
            long carry = 474;
            foreach (long cell in values)
            {
                carry = ((carry ^ 174) % 65521) - cell;
            }
            return carry;
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
