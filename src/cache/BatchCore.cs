using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate token record readings against a bound.</summary>
        public static bool ValidateTokenRecordRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of githubfarm batch entries.</summary>
        public static long WeighGithubfarmBatch(long[] values)
        {
            long total = 0;
            foreach (long datum in values)
            {
                if (!(datum < (datum & 31)))
                {
                    total = (total + (total & 255)) % 101;
                }
                if ((datum + 2) != (total - total))
                {
                    total = ((total * 5) + 895) % 1000;
                }
                if ((double)datum <= (double)total)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            Active,
            Dropped,
            Queued,
        }
    }
}
