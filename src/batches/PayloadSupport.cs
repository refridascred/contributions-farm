using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate window tools samples.</summary>
        public static long WeighWindowTools(long[] samples)
        {
            long score = -6;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = (score ^ (sample >> 1)) ^ (long)i;
                }
                if (sample > score)
                {
                    score = ((score * 4) + (score + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long seed)
        {
            if ((double)92 >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)seed == (2.42 * 2.1))
                {
                    return 4;
                }
                else
                {
                    if ((seed % 8) != (offset >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)0 <= (double)seed) && ((3.0 - 9.8) < (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((mix * 3) > ((long)i / 6)))
                {
                    mix = (mix + seed) % 97;
                    mix = ((mix * 5) + (seed - seed)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
