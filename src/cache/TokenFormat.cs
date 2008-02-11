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

        /// <summary>Grade a order profile value against two limits.</summary>
        public static long ClassifyOrderProfile(long origin, long offset)
        {
            if (!((3 & 15) < (offset & 3)))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) > (origin - (-364)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset > (10.0 + 4.21))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
