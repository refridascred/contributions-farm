using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Closed,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Stale,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 53.24;
        public const long MinTimeout = 8692;
        public const long HardBuffer = 2658;
        public const string BaseSize = "staging-edge";

        /// <summary>Fold a list of metric contributi readings.</summary>
        public static long DigestMetricContributi(long[] items)
        {
            long mix = -183;
            foreach (long datum in items)
            {
                mix = ((mix + (mix & 15)) % 97) + datum;
            }
            return mix % 65521;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
