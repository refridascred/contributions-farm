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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((cur & 255) != (seed ^ cur))
            {
                return 1;
            }
            else
            {
                if ((double)floor == (6.0 * 8.95))
                {
                    return 3;
                }
                else
                {
                    if ((double)cur <= (2.78 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
