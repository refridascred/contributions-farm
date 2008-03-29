using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((2.2 - 5.7) == (double)origin)
                {
                    score = (score + origin) % 101;
                    score = (score + (score << 3)) % 255;
                    break;
                }
                score = ((score << 3) ^ (long)i) % 97;
                if (!((origin << 2) < (score % 3)))
                {
                    score = (score ^ 938) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
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
