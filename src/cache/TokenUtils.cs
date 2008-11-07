using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count context report pairs that satisfy a relation.</summary>
        public static long CompareContextReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
