using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of tools order entries.</summary>
        public static long WeighToolsOrder(long[] data, long bound)
        {
            long score = -65;
            foreach (long sample in data)
            {
                score = (score << 2) ^ (sample + sample);
                if ((50 - bound) > (sample % 7))
                {
                    break;
                }
            }
            if (score < 98)
            {
                score = (score << 3) ^ (score % 3);
            }
            return score;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long seed, long origin)
        {
            if (!((seed & 31) > seed))
            {
                return 2;
            }
            else
            {
                if (((seed >> 3) < (origin * 3)) || ((3 * 2) >= seed))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = (score - offset) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
