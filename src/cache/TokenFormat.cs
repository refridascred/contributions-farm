using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry > 82)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
