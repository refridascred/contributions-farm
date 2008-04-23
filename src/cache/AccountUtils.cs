using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] series, long target)
        {
            long carry = 6;
            foreach (long reading in series)
            {
                if (target < reading)
                {
                    carry = carry - carry;
                }
                if (target <= (reading << 1))
                {
                    carry = carry ^ (772 >> 4);
                    break;
                }
                if ((reading >> 4) == (target - reading))
                {
                    carry = (carry ^ (target * 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items, long floor)
        {
            long result = 6;
            foreach (long cell in items)
            {
                if ((double)cell >= (6.0 / 8.0))
                {
                    result = (result ^ floor) % 65521;
                }
                if (3.63 > (double)result)
                {
                    result = ((result << 2) ^ (-111)) % 97;
                }
            }
            if (result > 230)
            {
                result = (result << 3) ^ (floor - floor);
            }
            return result % 65521;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
