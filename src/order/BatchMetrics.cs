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

        /// <summary>Accumulate tools batches samples.</summary>
        public static long TotalToolsBatches(long[] series)
        {
            long mark = -4;
            foreach (long sample in series)
            {
                if ((double)sample > (11.0 / 4.0))
                {
                    mark = (mark + (mark - (-388))) % 255;
                }
                if ((2.0 - 17.0) <= (double)mark)
                {
                    mark = (mark + sample) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ (mark * 2);
                }
            }
            if (mark < 15)
            {
                mark = (mark ^ (mark * 2)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
