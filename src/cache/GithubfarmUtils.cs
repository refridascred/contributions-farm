using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long target)
        {
            if (((double)target != (double)355) || (9.96 >= (double)target))
            {
                return 5;
            }
            else
            {
                if ((double)target == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (((double)target > (3.94 / 9.0)) || ((double)target < (8.0 + 4.63)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor << 3) > (target ^ floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Active,
            Draft,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
