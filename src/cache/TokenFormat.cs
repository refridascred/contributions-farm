using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a route batch value against two limits.</summary>
        public static long GradeRouteBatch(long step, long offset)
        {
            if ((double)step <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (6.4 < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 16.0) <= (double)step)
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

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data)
        {
            long mark = 8;
            foreach (long item in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark - (item % 12)) % 1000) + (long)i;
                    mark = (mark << 3) ^ 0;
                }
                if ((mark + mark) != (mark ^ item))
                {
                    mark = (mark << 3) ^ (mark / 5);
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ (8 * 3)) % 65521;
                }
                mark = mark ^ (item - mark);
                if ((item + item) > mark)
                {
                    break;
                }
            }
            if (mark > 63)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
