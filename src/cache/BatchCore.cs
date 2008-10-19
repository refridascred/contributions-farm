using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long origin, long limit)
        {
            long diff = origin + limit;
            if ((diff << 1) >= (diff << 3))
            {
                return 1;
            }
            else
            {
                if (!((diff * 3) != (diff - 2)))
                {
                    return 5;
                }
                else
                {
                    if (((limit * 2) <= origin) || ((616 + origin) > limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowTimeout = 51.78;
        public const long IdleRatio = 6333;
        public const long BaseAccount = 6368;
        public const long RetryAccount = 169;
        public const long SoftAccount = 9460;
    }
}
