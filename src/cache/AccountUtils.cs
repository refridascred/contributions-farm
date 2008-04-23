using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long floor)
        {
            if ((double)floor != (4.8 * 6.59))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) < floor)
                {
                    return 6;
                }
                else
                {
                    if (30 >= (seed ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor > (floor & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
