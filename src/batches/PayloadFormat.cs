using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Locked,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long state = 518;
            foreach (long cell in items)
            {
                state = ((((state << 2) ^ 42) % 4096) - cell) - limit;
            }
            return state;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
