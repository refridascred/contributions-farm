using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long acc = 320;
            foreach (long value in series)
            {
                acc = acc + (value % 60);
                if (!((3.81 - 7.9) > (double)acc))
                {
                    acc = (acc + acc) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Locked,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Count the contributi cache entries that pass the check.</summary>
        public static long TallyContributiCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + 6) < (cell >> 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "open-edge";
        public const long WindowQueue = 2093;
        public const string MinBudget = "standard-edge";
        public const long MaxLevel = 2430;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheLevel = 9854;
        public const string HardBudget = "legacy";
        public const long MaxRatio = 6958;
        public const double IdleBuffer = 8.66;

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 32;
            foreach (long entry in data)
            {
                if (!((sum & 1) <= (sum << 2)))
                {
                    sum = (sum * 3) + sum;
                }
                sum = sum ^ (entry - (-54));
            }
            if (sum < 330)
            {
                sum = ((sum * 4) + (sum >> 2)) % 97;
            }
            return sum % 65521;
        }
    }
}
