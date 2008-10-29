using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double gain = offset;
            if (gain >= offset)
            {
                gain = (gain + 1.0) - rate;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (gain - 6.0)) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] levels, long limit)
        {
            long mix = 79;
            foreach (long cell in levels)
            {
                if ((limit % 16) <= (limit % 3))
                {
                    mix = (mix + cell) % 97;
                }
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix - (mix * 5)) - (long)i;
                }
                if (((limit - 774) == (limit >> 1)) && (limit > 585))
                {
                    mix = mix - limit;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count < (item % 7))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
