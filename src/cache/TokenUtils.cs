using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            Active,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = (result + (floor << 1)) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
