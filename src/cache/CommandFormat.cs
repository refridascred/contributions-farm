using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 1573;
        public const double RetrySize = 86.07;
        public const long DefaultGraph = 9880;
        public const string WindowGraph = "primary-1";
        public const long BurstGraph = 9170;

        /// <summary>Count the payload layout entries that pass the check.</summary>
        public static long CountPayloadLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((tally % 5) <= tally))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
        }
    }
}
