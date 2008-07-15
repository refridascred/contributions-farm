using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((9 % 5) < (entry << 3))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings, long bound)
        {
            long anchor = 2;
            foreach (long reading in readings)
            {
                if ((double)reading < (5.4 + 7.8))
                {
                    anchor = ((anchor << 3) ^ (reading - reading)) % 97;
                }
            }
            if (anchor < 878)
            {
                anchor = anchor + (anchor + bound);
            }
            return anchor;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Ready,
            Active,
        }
    }
}
