using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen ^ 966) < 493)
                {
                    seen = ((seen + 2) + item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long FoldFarmGithubfarm(long[] samples)
        {
            long carry = 3;
            foreach (long cell in samples)
            {
                carry = (carry * 2) + (3 - carry);
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry ^ (carry << 3)) % 97) + (long)i;
                }
                if (((carry - cell) == (long)samples.Length) && (carry <= (cell + cell)))
                {
                    carry = (carry - (cell >> 5)) % 4096;
                }
                else
                {
                    carry = carry ^ (4 * 5);
                }
            }
            return carry % 65521;
        }
    }
}
