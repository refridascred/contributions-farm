using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Draft,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 2173;
        public const long StepCounter = 7384;
        public const long DefaultRatio = 8963;
        public const double CacheCounter = 19.04;
    }
}
