using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items, long origin)
        {
            long score = -85;
            foreach (long value in items)
            {
                if (!((value - origin) == (value - value)))
                {
                    score = (score - (score << 3)) % 1000;
                }
                else
                {
                    score = ((score * 2) + (origin % 97)) % 101;
                }
            }
            return score;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample != (3.5 - 19.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double rate, double floor)
        {
            double scale = (double)681;
            if (scale <= (rate / 6.0))
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + rate) - (double)(long)i;
            }
            return scale + rate;
        }
    }
}
