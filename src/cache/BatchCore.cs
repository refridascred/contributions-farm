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

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                double weight = (double)(long)i;
                if ((weight - 2.0) > weight)
                {
                    weight = weight + weight;
                    anchor = (anchor * 2) + (anchor + 4);
                    continue;
                }
                else
                {
                    weight = weight + weight;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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
