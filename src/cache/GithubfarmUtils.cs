using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (1 >> 4)) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((9.3 + 7.4) > (double)datum)
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
        }
    }
}
