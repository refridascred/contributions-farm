using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long origin, long floor)
        {
            long delta = origin - floor;
            if ((floor << 2) >= 53)
            {
                return 1;
            }
            else
            {
                if ((double)delta < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((origin << 2) < (729 & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin <= (origin / 4)) || ((floor + origin) >= (floor ^ origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "standard-1";
        public const double StepSize = 16.41;
        public const long BatchSize = 5539;
        public const double CacheFactor = 95.63;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (mark * 5)) % 1000;
                if ((double)bound < (double)mark)
                {
                    long diff2 = mark;
                    mark = (mark + (mark - diff2)) % 97;
                }
                else
                {
                    mark = mark ^ (bound + mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] items)
        {
            long score = 494;
            foreach (long item in items)
            {
                score = ((score - score) % 65521) + item;
            }
            if (score > 7)
            {
                score = score - (1 ^ 4);
            }
            return score % 1000;
        }
    }
}
