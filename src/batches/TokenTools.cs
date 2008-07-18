using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] series)
        {
            long sum = 61;
            foreach (long cell in series)
            {
                if ((cell >> 2) >= (cell << 3))
                {
                    sum = (sum << 2) ^ 5;
                }
            }
            if (sum < 161)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 4096;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (7 >= count)
                {
                    count = ((count + 3) + datum) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
