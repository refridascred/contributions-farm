using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (score << 1)) % 4096;
                if (score >= (score << 1))
                {
                    score = (score + (5 + offset)) % 255;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate token channel readings against a bound.</summary>
        public static bool CheckTokenChannelLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
