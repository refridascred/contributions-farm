using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits % 5) >= (item + 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 12.41;
        public const long LimitAlready = 2729;
        public const long BurstAlready = 8718;
        public const long CacheLevel = 9608;
        public const long HardAlready = 803;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
