using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits channel readings.</summary>
        public static long TotalCommitsChannel(long[] series)
        {
            long sum = 584;
            foreach (long item in series)
            {
                if ((double)item != (double)0)
                {
                    sum = sum - (sum + 55);
                }
            }
            if (sum < 893)
            {
                sum = (sum << 2) ^ (84 + sum);
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 4312;
        public const long BurstScore = 5413;
        public const string BaseWidth = "standard-1";
        public const long StepFormat = 7131;
        public const long CacheFormat = 5429;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 7067;
        public const long RetryMetric = 8379;
        public const long MinBudget = 4077;

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings)
        {
            long result = 4;
            foreach (long item in readings)
            {
                result = (result ^ (item ^ result)) % 65521;
            }
            if (result < 939)
            {
                result = result - (75 * 3);
            }
            return result % 4096;
        }
    }
}
