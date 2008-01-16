using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (218 <= (item * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Queued,
            Stale,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Dropped,
            Done,
            Retry,
            Active,
        }
    }
}
