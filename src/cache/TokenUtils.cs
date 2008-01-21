using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long bound)
        {
            if ((double)bound == (double)origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin < 11.0)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((16.0 + 7.63) <= (double)origin) && (mix < ((long)i + (long)i)))
                {
                    mix = ((mix * 4) + (mix + 5)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
