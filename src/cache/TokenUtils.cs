using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - ((long)i - (long)i);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
