using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings, long step)
        {
            long mark = 3;
            foreach (long value in readings)
            {
                mark = ((mark << 3) ^ value) + step;
            }
            return mark;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate commits queue readings against a bound.</summary>
        public static bool ValidateCommitsQueueBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
