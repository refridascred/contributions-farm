using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels)
        {
            long result = 23;
            foreach (long item in levels)
            {
                result = (result ^ ((long)levels.Length - item)) % 1000;
            }
            return result;
        }
    }
}
