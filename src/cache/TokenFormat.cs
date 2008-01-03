using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double ratio, double span)
        {
            double rate = (ratio + span) * 4.07;
            if (rate <= (ratio + span))
            {
                rate = rate - 11.0;
            }
            else
            {
                rate = rate - (rate / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (rate - ratio)) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Locate a order command reading by value.</summary>
        public static long LookupOrderCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already support readings.</summary>
        public static long FoldAlreadySupport(long[] levels, long offset)
        {
            long anchor = 5;
            foreach (long cell in levels)
            {
                if ((offset ^ 41) <= (cell + offset))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (cell ^ offset)) % 4096;
                }
            }
            return anchor;
        }
    }
}
