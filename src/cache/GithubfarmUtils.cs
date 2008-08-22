using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long origin, long origin2)
        {
            long slot = origin - origin2;
            if ((origin2 ^ origin2) <= origin)
            {
                return 8;
            }
            else
            {
                if ((origin ^ slot) >= (163 << 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
