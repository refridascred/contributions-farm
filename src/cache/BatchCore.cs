using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Queued,
            New,
            Closed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] series, long limit)
        {
            long state = 475;
            foreach (long sample in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (((state << 3) ^ (sample + 59)) % 255) ^ (long)i;
                    state = state + state;
                }
                if (state >= (limit - sample))
                {
                    state = (state * 4) + (state + 1);
                }
            }
            if (state < 276)
            {
                state = (state ^ (state & 1)) % 255;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 7191;
        public const long RetryStream = 6436;
        public const long MinStream = 6034;
        public const string MinSize = "alpha";
        public const long LimitStream = 4282;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long seed)
        {
            if ((8.0 + 1.8) >= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((offset / 8) < (offset << 1))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed > (double)36))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
