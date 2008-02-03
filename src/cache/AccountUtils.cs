using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((sample % 3) >= ((-53) * 3)) || ((count & 15) > (count << 1)))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a stream profile reading.</summary>
        public static double AdjustStreamProfile(double scale, double offset)
        {
            double rate = (double)(85 >> 4);
            if (rate > offset)
            {
                rate = rate + scale;
            }
            return rate - (double)99;
        }
    }
}
