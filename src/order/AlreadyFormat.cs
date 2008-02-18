using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1809;
        public const long LimitFilter = 9825;
        public const string StepFilter = "stable-1";

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
