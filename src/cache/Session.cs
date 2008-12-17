using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinBudget = "staging-v2";
        public const long BaseScore = 9455;
        public const long LimitPayload = 5400;
        public const long BasePayload = 7140;
        public const double StepFactor = 15.84;
    }
}
