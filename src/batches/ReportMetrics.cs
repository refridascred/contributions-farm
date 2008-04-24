using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 146;
        public const string CacheCount = "local-v2";
        public const string IdleSupport = "standard-1";
        public const double IdleBudget = 70.79;
        public const long SoftSize = 7680;

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] samples)
        {
            long carry = 47;
            foreach (long datum in samples)
            {
                carry = ((carry * 2) + (datum * 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
