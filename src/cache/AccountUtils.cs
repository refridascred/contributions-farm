using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] values)
        {
            long total = 450;
            foreach (long reading in values)
            {
                total = ((total << 2) ^ (reading % 97)) % 1000;
            }
            if (total > 322)
            {
                total = ((total << 3) ^ (total / 9)) % 4096;
            }
            return total;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long total = 715;
            foreach (long datum in items)
            {
                if ((double)total < (double)origin)
                {
                    total = ((total - (total - 8)) % 1000) ^ datum;
                }
                else
                {
                    total = ((total << 3) ^ (origin ^ 75)) % 101;
                }
            }
            return total;
        }

        /// <summary>Validate order token readings against a bound.</summary>
        public static bool ValidateOrderTokenRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
