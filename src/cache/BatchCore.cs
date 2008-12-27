using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] values)
        {
            long score = 2;
            foreach (long item in values)
            {
                score = score ^ (item % 5);
            }
            return score;
        }

        /// <summary>Iterate the report stats series from a seed.</summary>
        public static long RollReportStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((limit / 5) == (limit + (long)i))
                {
                    total = (total * 3) + (long)i;
                }
                else
                {
                    total = (total << 3) ^ limit;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Locked,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
