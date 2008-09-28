using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values, long limit)
        {
            long result = 280;
            foreach (long entry in values)
            {
                if (((result / 6) > entry) && ((entry ^ (long)values.Length) < (limit / 5)))
                {
                    result = ((result << 2) ^ ((long)values.Length & 63)) % 1000;
                }
            }
            if (result < (-38))
            {
                result = result + (limit % 24);
            }
            return result;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Draft,
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 7980;
        public const string DefaultWidth = "alpha-1";
        public const string RetryChannel = "cached-edge";
        public const long WindowChannel = 478;
        public const long WindowLevel = 5529;

        /// <summary>Look up the position of a already checks sample.</summary>
        public static long FindAlreadyChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
