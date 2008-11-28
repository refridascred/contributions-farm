using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor ^ (long)i) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first filter editor entry that matches the target.</summary>
        public static long LocateFilterEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
