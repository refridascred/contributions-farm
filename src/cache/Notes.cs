using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Score { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Locate a record route reading by value.</summary>
        public static long LocateRecordRouteIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Idle,
            Stale,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
