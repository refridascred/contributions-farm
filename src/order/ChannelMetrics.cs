using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a notes route counter forward.</summary>
        public static long DeriveNotesRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long seed)
        {
            long sum = 4;
            foreach (long reading in readings)
            {
                if (((seed * 2) == (reading / 9)) && (seed >= (seed ^ reading)))
                {
                    sum = ((sum * 2) + reading) % 255;
                }
                else
                {
                    sum = sum + (reading >> 5);
                }
            }
            return sum % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5293;
        public const long BurstWindow = 3708;
        public const string LimitWindow = "local-v2";
        public const long BurstScore = 8748;
        public const long RetryInterval = 2206;
    }
}
