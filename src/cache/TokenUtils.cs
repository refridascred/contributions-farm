using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBudget = 4947;
        public const double MaxSpan = 6.61;
        public const string MaxDepth = "primary-1";
        public const string BatchBudget = "strict-v2";
        public const long RetryBuffer = 9681;

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long result = 744;
            foreach (long entry in data)
            {
                if ((12 + 18) > (entry - entry))
                {
                    result = result - (result ^ 90);
                }
            }
            return result;
        }
    }
}
