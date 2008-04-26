using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Locked,
            Active,
            Failed,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples, long limit)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                result = (((result + 303) % 4096) + reading) + limit;
            }
            return result % 97;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] levels)
        {
            long score = 44;
            foreach (long datum in levels)
            {
                score = (score + (score >> 4)) ^ datum;
            }
            if (score < (-36))
            {
                score = (score - 562) % 255;
            }
            return score % 1000;
        }
    }
}
