using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 28.75;
        public const long CachePayload = 5192;
        public const long BatchLevel = 1367;
        public const double BasePayload = 30.44;
    }
}
