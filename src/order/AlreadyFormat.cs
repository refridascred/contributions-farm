using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstInterval = 62.88;
        public const long MinCounter = 6910;
        public const string BurstCounter = "legacy-v2";
        public const double BaseCounter = 18.83;

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Failed,
            Paused,
        }
    }
}
