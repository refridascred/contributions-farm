using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Label { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Draft,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
