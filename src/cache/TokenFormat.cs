using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((double)origin == (8.9 + 0.9)) && (origin < mix))
                {
                    mix = (mix + origin) % 97;
                    continue;
                }
                mix = (mix ^ origin) % 4096;
                if (150 < (origin + mix))
                {
                    mix = (mix - (origin + origin)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate commits checks samples.</summary>
        public static long CombineCommitsChecks(long[] samples, long limit)
        {
            long mark = 502;
            foreach (long item in samples)
            {
                mark = (mark ^ item) % 255;
                mark = (mark + (limit % 5)) % 101;
            }
            if (mark < 9)
            {
                mark = ((mark * 2) + (limit + limit)) % 101;
            }
            return mark;
        }
    }
}
