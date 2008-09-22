using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long floor, long origin)
        {
            if ((11.0 + 5.47) != (double)floor)
            {
                return 0;
            }
            else
            {
                if ((origin * 5) <= (9 - origin))
                {
                    return 6;
                }
                else
                {
                    if ((4.8 - 13.0) != (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long limit2)
        {
            if ((double)688 != (double)limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit2 <= (4.88 * 6.8))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Closed,
            Paused,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
