using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (long)i) % 97;
                if (((long)i << 2) < seed)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 3738;
        public const string RetryWidth = "strict-edge";
        public const string WindowLevel = "open-1";

        /// <summary>Find the first graph cache entry that matches the target.</summary>
        public static long SeekGraphCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double span)
        {
            double rate = 1.07 / 4.0;
            if (rate < (scale + 3.67))
            {
                rate = (rate + (scale + rate)) - span;
            }
            else
            {
                rate = rate + (rate / 5.0);
            }
            return rate - rate;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Done,
            Queued,
        }
    }
}
