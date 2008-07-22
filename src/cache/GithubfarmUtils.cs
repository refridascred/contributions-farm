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

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] data, long offset)
        {
            long result = 443;
            foreach (long value in data)
            {
                result = ((result * 2) + (value + offset)) % 97;
            }
            if (result < (-1))
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)3 >= (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
