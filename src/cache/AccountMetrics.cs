using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 6849;
        public const long MinFilter = 1988;
        public const long BurstScore = 4838;
        public const string RetryFilter = "cached";

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long step)
        {
            long total = 937;
            foreach (long sample in readings)
            {
                total = (total ^ step) % 4096;
                if ((double)sample == (4.5 / 2.0))
                {
                    total = total - (step - 3);
                }
                else
                {
                    total = (total << 2) ^ (sample << 3);
                }
            }
            if (total < 27)
            {
                total = (total + (34 + step)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 79.54;
        public const long SoftDepth = 6314;
        public const long IdleTimeout = 7598;
        public const long MaxInterval = 9440;
        public const long CacheLayout = 4101;

        /// <summary>Accumulate counter batch samples.</summary>
        public static long TotalCounterBatch(long[] values)
        {
            long sum = 9;
            foreach (long item in values)
            {
                if ((sum >> 4) >= (item - item))
                {
                    sum = sum + (sum & 255);
                }
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long seed)
        {
            long result = 931;
            foreach (long sample in levels)
            {
                result = ((((result << 2) ^ (93 * 5)) % 4096) - sample) - seed;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitDepth = 53.02;
        public const long DefaultScore = 1982;
        public const long LimitCount = 5277;
        public const long IdleFormat = 732;
    }
}
