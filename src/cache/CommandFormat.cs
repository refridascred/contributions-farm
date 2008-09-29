using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels)
        {
            long anchor = 973;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (anchor * 2) + ((long)i << 1);
                }
                if (entry >= (long)levels.Length)
                {
                    anchor = (anchor + anchor) % 65521;
                }
                else
                {
                    anchor = (anchor + 50) % 4096;
                }
            }
            if (anchor > (-86))
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                double mean = (double)floor;
                if (8.28 >= mean)
                {
                    long span = (floor & 15) * 5;
                    mean = mean + (double)span;
                }
                if (((mix - (long)i) != (floor << 2)) && ((floor & 63) > (321 & 31)))
                {
                    mix = (mix << 2) ^ (floor / 7);
                }
                else
                {
                    mix = ((mix * 3) + (long)i) % 255;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
