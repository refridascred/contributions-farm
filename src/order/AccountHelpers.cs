using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if (acc < (item + item))
                {
                    acc = ((acc * 3) + (acc / 2)) % 97;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 5) + (acc * 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a report buffer reading by value.</summary>
        public static long SeekReportBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
