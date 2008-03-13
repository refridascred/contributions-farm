using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of batch already entries.</summary>
        public static long DigestBatchAlready(long[] series)
        {
            long total = 1;
            foreach (long datum in series)
            {
                if (((4.0 / 8.0) != (double)datum) || (datum <= (695 % 97)))
                {
                    total = ((total << 2) ^ datum) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
