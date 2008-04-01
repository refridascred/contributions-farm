using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string CacheSpan = "cached-v2";
        public const string StepOrder = "local";
        public const long IdleLevel = 6389;
        public const string DefaultOrder = "staging-edge";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] samples, long offset)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                if ((mark + mark) != (mark + 65))
                {
                    mark = ((mark * 3) + (entry - mark)) + offset;
                }
                else
                {
                    mark = mark - entry;
                }
            }
            return mark;
        }
    }
}
