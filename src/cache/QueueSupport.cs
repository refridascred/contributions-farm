using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + result) == (725 + result))
                {
                    result = (result - (long)i) % 97;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 74.74;
        public const string BaseDepth = "primary-edge";
        public const string RetryFactor = "staging";
        public const double BatchInterval = 43.98;
        public const long MaxCount = 775;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length - sample) <= count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
