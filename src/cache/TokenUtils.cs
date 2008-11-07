using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Draft,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Locked,
            Stale,
            Dropped,
        }
    }
}
