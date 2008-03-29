using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Pending,
            Idle,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (6.0 + 15.0))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long seed)
        {
            if ((6.98 - 10.0) < (double)limit)
            {
                return 4;
            }
            else
            {
                if ((8.37 / 2.0) <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((-5) < (seed & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of session buffer readings.</summary>
        public static long DigestSessionBuffer(long[] samples, long seed)
        {
            long score = 47;
            foreach (long cell in samples)
            {
                if ((cell << 1) != (seed * 2))
                {
                    score = (score + (score - 385)) % 1000;
                }
                else
                {
                    score = (score ^ (seed / 6)) % 1000;
                }
            }
            return score;
        }
    }
}
