using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "strict-v2";
        public const long BaseSpan = 7096;
        public const string BatchSession = "alpha-edge";

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits / 8) <= cell) || ((cell - cell) >= (hits - cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine account payload values into a single score.</summary>
        public static long TotalAccountPayload(long[] samples)
        {
            long anchor = 845;
            foreach (long value in samples)
            {
                anchor = anchor ^ (anchor - value);
                if (((8.53 - 4.5) < (double)78) && ((double)value == (5.5 * 1.0)))
                {
                    anchor = anchor + (value % 60);
                }
            }
            return anchor;
        }
    }
}
