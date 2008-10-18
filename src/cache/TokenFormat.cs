using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings, long target)
        {
            long result = 360;
            foreach (long datum in readings)
            {
                result = (result * 4) + (target ^ datum);
            }
            return result % 1000;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
