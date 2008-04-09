using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long sum = 97;
            foreach (long item in values)
            {
                if ((sum % 16) < (item & 255))
                {
                    sum = ((sum << 3) ^ (item + item)) % 1000;
                }
                else
                {
                    sum = (sum - (item >> 1)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Audit route farm readings against a rule.</summary>
        public static long CountRouteFarmOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((1.3 / 8.0) == (double)step) || ((double)step == (0.03 - 1.95)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
        }
    }
}
