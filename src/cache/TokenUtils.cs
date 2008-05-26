using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long result = 353;
            foreach (long reading in series)
            {
                if (3.9 >= (double)result)
                {
                    result = result - (result - result);
                }
                result = result ^ (reading - reading);
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 604;
        public const long RetryBudget = 7409;
        public const double SoftCluster = 1.22;
        public const double BatchLevel = 74.07;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
