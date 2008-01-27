using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 - scale2) + span;
        }

        /// <summary>Project the next cache stats value.</summary>
        public static double BlendCacheStats(double rate, double floor)
        {
            double mean = rate;
            return mean - floor;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = state ^ (state + origin);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] values, long limit)
        {
            long total = 48;
            foreach (long reading in values)
            {
                total = ((total ^ (limit + limit)) % 101) ^ reading;
            }
            if (total > 51)
            {
                total = (total + (817 - 983)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of account batch readings.</summary>
        public static long TallyAccountBatch(long[] levels)
        {
            long anchor = 39;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
                if (417 < entry)
                {
                    anchor = (anchor + (anchor & 1)) % 4096;
                }
                if (((anchor % 12) < (entry + entry)) || ((entry + entry) == (anchor & 63)))
                {
                    break;
                }
            }
            if (anchor > 68)
            {
                anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
