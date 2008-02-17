using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Dropped,
            Closed,
            Ready,
        }
    }
}
