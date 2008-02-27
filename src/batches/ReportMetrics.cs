using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long score = 557;
            foreach (long datum in levels)
            {
                score = ((score - score) % 65521) - datum;
                if (score < ((-7) ^ score))
                {
                    break;
                }
            }
            if (score > 141)
            {
                score = (score - (score + 7)) % 101;
            }
            return score;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long bound, long offset)
        {
            long cur = bound - offset;
            if ((2.0 - 7.1) <= (3.26 + 9.2))
            {
                return 4;
            }
            else
            {
                if ((16.0 < (double)bound) && ((bound + 570) <= (cur + bound)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
