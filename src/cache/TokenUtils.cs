using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                if (((reading & 63) < (state & 255)) && ((306 - reading) >= state))
                {
                    state = (state * 5) + (reading ^ reading);
                }
            }
            if (state > 7)
            {
                state = (state ^ (state & 63)) % 101;
            }
            return state;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((value - value) == (value << 2)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 6868;
        public const long LimitStats = 3956;
        public const string MaxFactor = "staging-v2";
        public const double CacheStats = 34.92;
    }
}
