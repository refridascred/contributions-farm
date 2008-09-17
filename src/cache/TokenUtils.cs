using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Done,
            Failed,
            New,
            Stale,
        }

        /// <summary>Look up the position of a checks metrics sample.</summary>
        public static long LookupChecksMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
