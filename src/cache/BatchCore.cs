using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 5559;
        public const long MinRecord = 1187;
        public const long BurstCount = 4676;
        public const long MaxSize = 1096;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long origin, long target)
        {
            long slot = origin ^ target;
            if ((9.87 / 9.0) < (double)target)
            {
                return 1;
            }
            else
            {
                if (2.9 > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((slot + 9) < (slot + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                if (state < (sample % 5))
                {
                    state = state ^ sample;
                }
                else
                {
                    state = (state - (state << 2)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
