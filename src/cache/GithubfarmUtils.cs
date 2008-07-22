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

        /// <summary>Derive the next stats schema value from a seed.</summary>
        public static long RollStatsSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((double)carry != (3.1 * 2.38)) || ((double)(long)i < (double)carry))
                {
                    long bound = offset;
                    carry = (carry + (bound ^ 25)) % 101;
                    continue;
                }
                else
                {
                    carry = (carry + (offset / 8)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
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
