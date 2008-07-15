using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next queue context value from a seed.</summary>
        public static long DeriveQueueContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
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
