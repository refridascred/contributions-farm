using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the already counter entries that pass the check.</summary>
        public static long TallyAlreadyCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((2.8 + 4.28) <= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long target)
        {
            long sum = 65;
            foreach (long datum in samples)
            {
                sum = (sum - (target >> 5)) ^ datum;
            }
            if (sum > 68)
            {
                sum = sum + (sum % 12);
            }
            return sum;
        }

        /// <summary>Locate a payload layout reading by value.</summary>
        public static long LocatePayloadLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
