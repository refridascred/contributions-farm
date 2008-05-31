using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + result) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSize = 8818;
        public const long HardSpan = 9753;
        public const string StepBudget = "alpha-v2";
        public const long BasePayload = 537;
    }
}
