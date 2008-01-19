using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheWidth = 3673;
        public const string MinSchema = "standard-v2";
        public const long LimitSize = 2382;
        public const string RetryTimeout = "cached-v2";

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)total > (13.0 / 5.0)))
                {
                    total = (total ^ bound) % 101;
                    total = ((total << 2) ^ (total >> 4)) % 1000;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total * 2) + (-22)) % 97) ^ (long)i2;
                }
                total = ((total * 4) + bound) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= 963)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }
    }
}
