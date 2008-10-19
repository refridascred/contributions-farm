using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long target)
        {
            if (target > ((-69) >> 2))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (9.4 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long offset, long offset2)
        {
            long cur = offset + offset2;
            if (!((offset2 ^ offset2) > offset))
            {
                return 2;
            }
            else
            {
                if ((double)cur >= 4.8)
                {
                    return 1;
                }
                else
                {
                    if (cur >= (offset / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4 ^ cur) < (75 - offset2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor + 535) >= (floor - score))
                {
                    score = (score + (score + score)) % 97;
                }
                else
                {
                    score = score - (floor ^ (long)i);
                }
                score = (score + (floor - (long)i)) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
