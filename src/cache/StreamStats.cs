using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftInterval = 6564;
        public const long IdleCommits = 8552;
        public const long MaxCommits = 3376;
        public const double BatchCommits = 91.85;
        public const long BatchTimeout = 161;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a token session sample.</summary>
        public static long SeekTokenSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
