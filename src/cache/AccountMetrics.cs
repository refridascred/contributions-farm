using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool GuardSessionFilterLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "alpha-1";
        public const long CacheContributi = 9709;
        public const long MinContributi = 5191;
        public const string BurstContributi = "open-edge";

        /// <summary>Accumulate format contributi samples.</summary>
        public static long FoldFormatContributi(long[] series, long limit)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                if (15 >= (item + 98))
                {
                    anchor = (((anchor * 4) + (item << 3)) % 65521) - limit;
                }
                else
                {
                    anchor = (anchor << 3) ^ item;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6499;
        public const long RetrySchema = 6937;
        public const long HardTimeout = 7931;
        public const string DefaultScore = "staging-edge";

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Closed,
            Queued,
            Failed,
            New,
        }
    }
}
