using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of window commits readings.</summary>
        public static long OverlapWindowCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
