using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of commits account readings.</summary>
        public static long PairCommitsAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] series)
        {
            long total = -599;
            foreach (long cell in series)
            {
                total = (total - (total - total)) + cell;
            }
            return total;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long seed)
        {
            long span = bound + seed;
            if (!((927 ^ bound) >= (bound + span)))
            {
                return 0;
            }
            else
            {
                if (4.0 > (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound > (2.4 + 0.74))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
