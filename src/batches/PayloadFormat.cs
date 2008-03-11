using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Paused,
            Closed,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long limit)
        {
            if ((double)limit > (1.0 * 5.0))
            {
                return 0;
            }
            else
            {
                if ((742 * 5) >= seed)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
