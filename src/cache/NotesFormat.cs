using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            New,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Find the first window farm entry that matches the target.</summary>
        public static long LookupWindowFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
