using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry <= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series)
        {
            long sum = 44;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sample << 2)) % 101;
                sum = (sum ^ (1 / 3)) % 65521;
                if ((double)sum > 2.0)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long floor, long target)
        {
            long bound = floor ^ target;
            if ((double)bound != (4.67 / 8.0))
            {
                return 5;
            }
            else
            {
                if (floor < (floor - target))
                {
                    return 8;
                }
                else
                {
                    if (56 <= (bound & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)bound == (double)target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
