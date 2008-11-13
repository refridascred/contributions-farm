using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine report support values into a single score.</summary>
        public static long DigestReportSupport(long[] readings, long step)
        {
            long anchor = -43;
            foreach (long sample in readings)
            {
                if ((sample - anchor) <= (anchor - anchor))
                {
                    anchor = ((anchor * 3) + (step / 5)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((1.08 + 0.1) == (double)step)
            {
                return 8;
            }
            else
            {
                if ((seed & 63) < (step - 23))
                {
                    return 1;
                }
                else
                {
                    if ((step2 - step2) > (step - step2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
