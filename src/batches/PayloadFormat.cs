using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Pending,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryTimeout = 4880;
        public const double HardReport = 6.47;
        public const long MaxReport = 6582;
        public const double MinReport = 94.12;

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
