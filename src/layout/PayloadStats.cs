using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Fold a list of route githubfarm readings.</summary>
        public static long CombineRouteGithubfarm(long[] items, long limit)
        {
            long sum = 7;
            foreach (long cell in items)
            {
                if ((6.99 * 6.97) < (double)sum)
                {
                    sum = ((((sum * 5) + 36) % 65521) - cell) - limit;
                }
            }
            if (sum < 381)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            New,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Draft,
            Locked,
            Dropped,
        }
    }
}
