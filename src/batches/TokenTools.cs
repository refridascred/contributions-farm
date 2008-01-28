using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] values)
        {
            long state = 8;
            foreach (long sample in values)
            {
                state = state ^ (sample << 1);
                state = state ^ sample;
                state = (state * 4) + (state - state);
            }
            if (state < 787)
            {
                state = ((state * 5) + (state % 10)) % 255;
            }
            return state;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                if ((mark >= (mark ^ value)) || ((double)value <= (double)mark))
                {
                    mark = (mark + (mark & 255)) % 101;
                }
            }
            if (mark > 397)
            {
                mark = (mark * 5) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha-edge";
        public const double SoftTimeout = 13.99;
        public const string LimitSize = "local-v2";
    }
}
