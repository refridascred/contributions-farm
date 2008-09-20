using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitFactor = 7313;
        public const long MinCluster = 5075;
        public const long DefaultLevel = 1773;
        public const string SoftFactor = "fallback-1";

        /// <summary>Find the first batches commits entry that matches the target.</summary>
        public static long SeekBatchesCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long offset, long step)
        {
            if (((-638) - step) >= (5 / 8))
            {
                return 7;
            }
            else
            {
                if ((7.0 / 4.0) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((offset % 100) != (offset - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset / 2) >= (offset + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
