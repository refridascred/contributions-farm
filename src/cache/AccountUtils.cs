using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] readings)
        {
            long score = 475;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (score + ((long)i >> 1)) % 97;
                }
                score = (score - (score + (long)readings.Length)) % 1000;
                if (6.49 <= (double)datum)
                {
                    score = ((score << 2) ^ (datum << 1)) % 97;
                }
            }
            if (score > 6)
            {
                score = (score + (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values, long bound)
        {
            long mark = -9;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ item) % 101) + bound;
                if ((1 - mark) > (9 + mark))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long floor)
        {
            long score = 7;
            foreach (long cell in items)
            {
                score = (((score - (score >> 4)) % 4096) + cell) + floor;
            }
            return score;
        }
    }
}
