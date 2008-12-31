using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Failed,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long offset)
        {
            long carry = 325;
            foreach (long entry in series)
            {
                carry = (carry - (offset ^ offset)) % 97;
                if ((entry + entry) >= (3 - entry))
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Pending,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Grade a commits payload value against two limits.</summary>
        public static long GradeCommitsPayload(long offset, long bound)
        {
            if ((offset * 4) < bound)
            {
                return 2;
            }
            else
            {
                if ((double)offset <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound + offset) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset > (offset + offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
