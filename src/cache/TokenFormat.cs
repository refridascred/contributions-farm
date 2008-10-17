using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] levels)
        {
            long result = 913;
            foreach (long value in levels)
            {
                result = result - (20 + result);
                result = (result - ((long)levels.Length & 31)) % 101;
                if (!((8 * 2) > (value + 23)))
                {
                    result = (result + (result - value)) % 1000;
                }
                else
                {
                    result = ((result * 4) + (value / 8)) % 4096;
                }
            }
            if (result < 943)
            {
                result = (result + (result / 4)) % 255;
            }
            return result % 4096;
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
