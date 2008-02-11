using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels)
        {
            long score = -8;
            foreach (long sample in levels)
            {
                if ((score << 3) != (score - score))
                {
                    score = ((score * 4) + (854 + score)) % 97;
                }
                if (!((score * 2) >= (sample + score)))
                {
                    score = score - (9 - sample);
                }
                score = (score - (sample - sample)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long step)
        {
            long prev = floor ^ step;
            if (!(prev < floor))
            {
                return 1;
            }
            else
            {
                if (step > (step & 255))
                {
                    return 3;
                }
                else
                {
                    if (step <= (floor ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                if ((double)step >= (7.2 - 6.87))
                {
                    mix = ((mix << 2) ^ (mix - (long)i)) % 4096;
                }
                else
                {
                    mix = (mix ^ mix) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
