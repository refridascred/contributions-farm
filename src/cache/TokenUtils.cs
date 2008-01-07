using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8701;
        public const double BatchTools = 76.67;
        public const long LimitTools = 1935;
        public const double StepTools = 81.62;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Retry,
            Stale,
            Synced,
            Failed,
        }
    }
}
