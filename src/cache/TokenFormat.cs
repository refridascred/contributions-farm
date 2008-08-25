using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long offset)
        {
            long prev = limit ^ offset;
            if ((double)offset < (3.45 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((limit & 63) == (prev - 9))
                {
                    return 3;
                }
                else
                {
                    if (prev > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long target)
        {
            long score = 2;
            foreach (long entry in samples)
            {
                score = (score - (351 - target)) ^ entry;
            }
            return score % 97;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!(((9 + 95) != (floor + 35)) || ((mark % 97) <= floor)))
                {
                    mark = mark + (floor * 4);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
