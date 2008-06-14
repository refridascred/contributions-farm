using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
