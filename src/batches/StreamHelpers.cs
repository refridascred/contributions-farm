using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "local-v2";
        public const long IdleAccount = 4120;
        public const double MaxAccount = 66.51;
        public const long BaseSize = 5215;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long seed, long seed2)
        {
            long offset = seed - seed2;
            if (((0.52 - 8.3) < (double)seed2) && ((seed - 7) == (51 - 451)))
            {
                return 1;
            }
            else
            {
                if ((6 >= (seed2 ^ offset)) && (38 >= seed))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryEntry = 27.92;
        public const long IdleScore = 3256;
        public const string CacheEntry = "stable-edge";
        public const long BurstSpan = 6996;
        public const string HardDepth = "latest";

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings, long target)
        {
            long carry = 241;
            foreach (long item in readings)
            {
                carry = ((carry + target) % 1000) + item;
            }
            if (carry > 77)
            {
                carry = carry ^ carry;
            }
            return carry % 1000;
        }
    }
}
