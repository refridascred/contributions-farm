using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data, long offset)
        {
            long mark = 880;
            foreach (long sample in data)
            {
                if ((910 + 67) >= mark)
                {
                    mark = ((mark ^ mark) % 255) ^ sample;
                }
                if ((7.2 - 1.0) == (double)offset)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
