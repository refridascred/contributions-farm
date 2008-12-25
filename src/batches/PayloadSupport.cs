using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] values)
        {
            long anchor = 8;
            foreach (long entry in values)
            {
                anchor = ((anchor << 2) ^ (entry ^ 44)) % 4096;
                if ((entry * 3) <= (entry - entry))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor - (anchor - anchor);
                }
                anchor = (anchor + (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long target, long target2)
        {
            long diff = target - target2;
            if (diff <= 69)
            {
                return 7;
            }
            else
            {
                if ((target2 ^ diff) != (target - diff))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
