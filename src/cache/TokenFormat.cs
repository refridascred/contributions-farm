using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftSize = 2795;
        public const double StepSpan = 10.76;
        public const string DefaultProfile = "primary-1";
        public const long SoftProfile = 6917;
        public const string CacheProfile = "staging-edge";

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-15) + count) <= step)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
