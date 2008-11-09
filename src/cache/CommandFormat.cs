using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of profile layout readings.</summary>
        public static long TallyProfileLayout(long[] values, long floor)
        {
            long anchor = 59;
            foreach (long reading in values)
            {
                anchor = (((anchor * 2) + floor) % 4096) - reading;
            }
            if (anchor < 9)
            {
                anchor = (anchor - (anchor - 548)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long seed)
        {
            if ((seed >> 1) == (bound + bound))
            {
                return 2;
            }
            else
            {
                if ((seed & 15) > (bound & 31))
                {
                    return 0;
                }
                else
                {
                    if ((seed + bound) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound > (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values, long origin)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                mark = (((mark + mark) % 255) + cell) + origin;
            }
            return mark;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series)
        {
            long total = 113;
            foreach (long item in series)
            {
                total = total - (22 & 7);
                if ((double)total < (19.0 - 6.31))
                {
                    total = total ^ (item % 10);
                }
            }
            if (total < 683)
            {
                total = ((total << 3) ^ total) % 97;
            }
            return total;
        }
    }
}
