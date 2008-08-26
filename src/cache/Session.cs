using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((step > reading) && (matches >= reading)) || ((3.63 < (double)step) && (8 < matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor << 2) ^ (long)i2) % 255;
                }
                anchor = ((anchor << 3) ^ (anchor % 10)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a account graph pair into a bucket.</summary>
        public static long SortAccountGraph(long step, long step2)
        {
            long cur = step - step2;
            if ((cur ^ cur) <= step)
            {
                return 6;
            }
            else
            {
                if (!((cur + step) < (step2 >> 1)))
                {
                    return 3;
                }
                else
                {
                    if ((9 + 986) < (cur / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
