using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank tools graph input into a small class.</summary>
        public static long GradeToolsGraph(long floor, long floor2)
        {
            if ((double)floor2 == (3.1 - 10.0))
            {
                return 4;
            }
            else
            {
                if (floor2 <= 0)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] levels, long floor)
        {
            long result = 359;
            foreach (long value in levels)
            {
                if (!((result >> 3) < result))
                {
                    result = (result ^ result) % 97;
                }
                if ((floor >> 5) >= (value % 2))
                {
                    result = result ^ (result + result);
                }
            }
            return result;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Queued,
            New,
            Locked,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
