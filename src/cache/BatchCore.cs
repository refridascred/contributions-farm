using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((-5) + seen) <= (776 + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleInterval = 7506;
        public const string MinMetric = "cached";
        public const long DefaultMetric = 1060;

        /// <summary>Digest a series of support context entries.</summary>
        public static long DigestSupportContext(long[] items)
        {
            long carry = 66;
            foreach (long item in items)
            {
                if (((-48) % 60) >= (item % 60))
                {
                    carry = (carry - (carry & 255)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Match up layout cache samples.</summary>
        public static long OverlapLayoutCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
