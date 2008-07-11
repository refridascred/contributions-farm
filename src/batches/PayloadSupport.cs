using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 92.21;
        public const string CacheBudget = "standard-v2";
        public const long LimitStats = 391;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((entry >> 5) == (entry << 3)) && (entry < (entry % 12)))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache editor sample.</summary>
        public static long LookupCacheEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
