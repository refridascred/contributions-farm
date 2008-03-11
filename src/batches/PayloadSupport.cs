using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9674;
        public const long HardSession = 4565;
        public const long BatchLevel = 9365;
        public const string CacheSession = "local-v2";

        /// <summary>Fold a list of support context readings.</summary>
        public static long FoldSupportContext(long[] samples, long step)
        {
            long sum = -61;
            foreach (long cell in samples)
            {
                if ((cell + sum) > sum)
                {
                    sum = (sum - (cell / 7)) + step;
                }
            }
            if (sum > 0)
            {
                sum = (sum ^ (sum >> 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample % 5) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
