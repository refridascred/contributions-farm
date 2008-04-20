using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values)
        {
            long sum = 723;
            foreach (long sample in values)
            {
                if ((sample - sample) != (sample - 4))
                {
                    sum = ((sum << 2) ^ (94 >> 5)) % 1000;
                }
            }
            if (sum > 6)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Queued,
            Locked,
        }
    }
}
