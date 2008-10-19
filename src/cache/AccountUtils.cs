using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first commits context entry that matches the target.</summary>
        public static long LookupCommitsContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long step, long limit)
        {
            long span = step - limit;
            if (((limit + 4) == (limit + span)) || ((double)limit != (double)step))
            {
                return 8;
            }
            else
            {
                if ((1.32 + 1.02) != (double)span)
                {
                    return 1;
                }
                else
                {
                    if ((8.62 / 8.0) >= (double)span)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 34.76;
        public const string RetryRatio = "stable-1";
        public const long CacheTimeout = 8737;
    }
}
