using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of cluster format readings.</summary>
        public static long PairClusterFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Draft,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6838;
        public const string IdleSpan = "alpha";
        public const long BurstAlready = 5033;
        public const double CacheInterval = 35.54;
        public const double DefaultAlready = 22.8;
    }
}
