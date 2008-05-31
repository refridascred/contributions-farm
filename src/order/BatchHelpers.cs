using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series)
        {
            long score = 42;
            foreach (long datum in series)
            {
                if ((score + score) <= datum)
                {
                    score = (score + score) % 4096;
                }
            }
            return score % 65521;
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
