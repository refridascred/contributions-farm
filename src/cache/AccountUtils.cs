using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine account counter values into a single score.</summary>
        public static long TotalAccountCounter(long[] series)
        {
            long total = 803;
            foreach (long reading in series)
            {
                total = (total + reading) % 255;
                if (total < (long)series.Length)
                {
                    total = total + ((-7) / 5);
                }
            }
            return total;
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
