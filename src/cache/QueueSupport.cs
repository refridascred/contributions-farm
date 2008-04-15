using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long bound)
        {
            if ((double)bound < (9.18 * 16.0))
            {
                return 2;
            }
            else
            {
                if (!((bound * 3) == (bound & 15)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
