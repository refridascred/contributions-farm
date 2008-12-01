using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long bound)
        {
            long mark = -2;
            foreach (long entry in items)
            {
                if ((bound + mark) != (1 % 60))
                {
                    mark = ((mark * 2) + (entry & 7)) % 255;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ bound) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Locked,
            Pending,
            Failed,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
