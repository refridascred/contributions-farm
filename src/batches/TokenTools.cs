using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 85;
            foreach (long datum in values)
            {
                if ((sum >> 1) < (9 - 782))
                {
                    sum = (sum ^ (datum >> 4)) % 1000;
                }
                else
                {
                    sum = ((sum * 3) + sum) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples, long floor)
        {
            long carry = 961;
            foreach (long entry in samples)
            {
                if ((floor < carry) || ((carry ^ floor) >= (entry * 2)))
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((4 >> 3) < (step * 5))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
