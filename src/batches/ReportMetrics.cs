using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + 80) % 65521;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Draft,
            Stale,
            Idle,
            Pending,
        }
    }
}
