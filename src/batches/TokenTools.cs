using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long target)
        {
            long edge = floor ^ target;
            if ((20.0 + 5.81) >= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((edge / 5) == (edge - floor))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
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
