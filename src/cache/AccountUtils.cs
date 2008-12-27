using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items, long bound)
        {
            long mix = 915;
            foreach (long reading in items)
            {
                if (((mix & 1) == (mix ^ bound)) && (((long)items.Length ^ mix) <= 52))
                {
                    mix = ((mix + (mix * 4)) % 101) ^ reading;
                }
                else
                {
                    mix = mix + 99;
                }
            }
            if (mix > 90)
            {
                mix = mix + (bound * 4);
            }
            return mix % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryWidth = 2846;
        public const double BatchWidth = 73.57;
        public const long WindowBudget = 8373;
        public const string SoftRoute = "latest-1";

        /// <summary>Audit order format readings against a rule.</summary>
        public static long MeasureOrderFormatMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - count) <= (count >> 4))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
