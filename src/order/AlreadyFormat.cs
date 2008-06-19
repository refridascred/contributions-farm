using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = state ^ state;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Locked,
            New,
            Queued,
            Active,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
