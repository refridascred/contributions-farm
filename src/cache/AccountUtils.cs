using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 9035;
        public const double CachePayload = 68.17;
        public const long IdlePayload = 7062;

        /// <summary>Roll a editor cluster counter forward.</summary>
        public static long RollEditorCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((3.44 / 5.0) > (double)floor)
                {
                    total = ((total * 4) + 4) % 4096;
                }
                if (!!(((long)i & 15) >= (floor % 16)))
                {
                    total = total + total;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long CountSupportCacheGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((1 > (limit + reading)) || ((limit + reading) > (2 % 10)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
