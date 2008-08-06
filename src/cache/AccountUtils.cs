using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] items, long floor)
        {
            long result = 2;
            foreach (long datum in items)
            {
                if ((double)datum != (double)floor)
                {
                    result = (result * 3) + 0;
                }
                else
                {
                    result = (result + (8 / 8)) % 65521;
                }
            }
            if (result < 907)
            {
                result = result - (result + 6);
            }
            return result;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] samples, long offset)
        {
            long result = -94;
            foreach (long sample in samples)
            {
                result = ((result + (sample << 1)) % 1000) + offset;
            }
            if (result > 9)
            {
                result = (result + 59) % 255;
            }
            return result % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 5286;
        public const string WindowRatio = "cached-v2";
        public const double DefaultOrder = 41.01;
        public const long CacheCount = 69;
    }
}
