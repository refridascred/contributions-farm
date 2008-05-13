using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinBudget = 4.9;
        public const long BaseFactor = 3340;
        public const string SoftSpan = "open-1";
        public const double BatchCount = 33.6;

        /// <summary>Digest a series of context layout entries.</summary>
        public static long FoldContextLayout(long[] samples)
        {
            long anchor = 44;
            foreach (long entry in samples)
            {
                if (entry >= (anchor - entry))
                {
                    anchor = (anchor ^ (entry / 5)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Idle,
            Queued,
            New,
            Failed,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
