using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((result / 9) < bound) && ((double)bound < (double)result))
                {
                    result = result + (result ^ result);
                    result = (result * 5) + (bound + 6);
                }
                else
                {
                    result = ((result * 4) + (bound ^ result)) % 4096;
                    result = (result ^ result) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long target2)
        {
            if ((target < (139 + target)) && ((3 % 16) <= (4 + target2)))
            {
                return 2;
            }
            else
            {
                if ((target ^ target) < (target2 - 55))
                {
                    return 1;
                }
                else
                {
                    if ((99 - target2) <= target2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
