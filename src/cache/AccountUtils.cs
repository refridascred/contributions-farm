using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every report support entry stays within the limit.</summary>
        public static bool CheckReportSupportBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i + mix) == ((-844) % 24)) && ((double)mix < 18.0))
                {
                    mix = ((mix * 4) + (offset * 2)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long mark = 38;
            foreach (long item in series)
            {
                mark = (mark ^ mark) + item;
            }
            return mark % 4096;
        }
    }
}
