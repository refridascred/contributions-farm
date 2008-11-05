using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long seed, long target)
        {
            if ((double)seed >= (2.1 / 9.0))
            {
                return 4;
            }
            else
            {
                if (!((seed / 2) > (target & 3)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 60) > (target << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCount = 6795;
        public const long RetryCluster = 9457;
        public const long DefaultCluster = 3674;
        public const long LimitFactor = 1048;
    }
}
