using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry * 4) <= (matches - entry)) || (matches < (entry + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
